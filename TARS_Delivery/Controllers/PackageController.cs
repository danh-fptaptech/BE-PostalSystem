using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;
using TARS_Delivery.Services;
using JsonException = Newtonsoft.Json.JsonException;

namespace TARS_Delivery.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PackageController : ControllerBase
{
    private readonly IPackageService _packageService;
    private readonly IItemService _itemService;
    private readonly IHistoryLogService _historyLogService;
    private readonly DatabaseContext _db;

    public PackageController(IPackageService packageService, IItemService itemService,
        IHistoryLogService historyLogService, DatabaseContext db)
    {
        _packageService = packageService;
        _itemService = itemService;
        _historyLogService = historyLogService;
        _db = db;
    }

    #region Get all packages

    [HttpGet]
    [Route("all")]
    public async Task<ActionResult<ICollection<SDTOPackageList>>> GetAllPackages()
    {
        ICollection<Package> packages = await _packageService.GetAllPackages();
        if (packages.Count == 0)
        {
            return NoContent();
        }

        return Ok(packages);
    }

    #endregion

    #region Get a package by id

    [HttpGet]
    [Route("getbyid/{id}")]
    public async Task<ActionResult<Package>> GetPackageById(int id)
    {
        Package package = await _packageService.GetPackageById(id);
        if (package == null)
        {
            return NotFound();
        }

        return Ok(package);
    }

    #endregion

    #region Get a package by tracking number and phoneFrom

    [HttpGet]
    [Route("getbytracking/{trackingNumber}/{phoneFrom}")]
    public async Task<ActionResult<Package>> GetPackageByTrackingNumber(string trackingNumber, string phoneFrom)
    {
        Package package = await _packageService.GetPackageByTrackingNumber(trackingNumber, phoneFrom);
        if (package == null)
        {
            return NotFound();
        }
        return Ok(package);
    }

    #endregion

    #region Create a new package

    [HttpPost]
    [Route("add")]
    public async Task<ActionResult> AddPackage()
    {   
        using var trans = await _db.Database.BeginTransactionAsync();
        try
        {
            using var reader = new StreamReader(Request.Body);
            string jsonBody = await reader.ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(jsonBody);
            RDTOPackage package = new RDTOPackage();
            //Info sender
            package.NameFrom = data.sender.fullName;
            package.PhoneFrom = data.sender.phoneNumber;
            package.AddressFrom = data.sender.address + ", Ward: " + data.sender.ward + ", District: " +
                                  data.sender.district + ", Province: " + data.sender.province;
            package.PostalCodeFrom = data.sender.postalCode;
            //Info receiver
            package.NameTo = data.receiver.fullName;
            package.PhoneTo = data.receiver.phoneNumber;
            package.AddressTo = data.receiver.address + ", Ward: " + data.receiver.ward + ", District: " +
                                data.receiver.district + ", Province: " + data.receiver.province;
            package.PostalCodeTo = data.receiver.postalCode;
            //Info package
            bool employCheck = !string.IsNullOrEmpty(data.submitBy.employeeCode?.ToString());

            package.FeeCustomId = data.service.serviceId;
            package.PackageNote = data.packageNote;
            package.PackageSize = data.packageSize.ToString();
            package.PackageType = data.type == "document" ? EItemType.Document : EItemType.Pack;
            package.TimeProcess = int.Parse(data.service.timeProcess.ToString());
            package.EmployeeCode = employCheck ? data.submitBy.employeeCode.ToString() : null;
            package.UserId = employCheck ? null : int.Parse(data.submitBy.id.ToString());
            package.EmployeeId = employCheck ? int.Parse(data.submitBy.id.ToString()) : null;
            package.TotalFee = decimal.Parse(data.fee.ToString());
            package.COD = int.Parse(data.cod.ToString());
            package.Step = employCheck ? EPackageStatus.Created : EPackageStatus.WaitingForPickup;
            //Add package by service
            var newPackage = await _packageService.AddPackage(package);
            foreach (var item in data.items)
            {
                Item newItem = new Item();
                newItem.ItemName = item.itemName;
                newItem.ItemQuantity = int.Parse(item.itemQuantity.ToString());
                newItem.ItemWeight = int.Parse(item.itemWeight.ToString());
                newItem.ItemValue = !string.IsNullOrEmpty(item.ItemValue) ? decimal.Parse(item.ItemValue) : 0;
                newItem.PackageId = newPackage.Id;
                await _itemService.AddItem(newItem);
            }

            HistoryLog log = new HistoryLog();
            log.PackageId = newPackage.Id;
            log.EmployeeId = employCheck ? int.Parse(data.submitBy.id.ToString()) : null;
            log.Step = data.submitBy.employeeCode != null ? EPackageStatus.Created : EPackageStatus.WaitingForPickup;
            log.HistoryNote = data.employeeProcess?.historyNote??null;
            log.Photos = data.employeeProcess?.photo??null;
            log.EmployeeIdNextStep = data.employeeProcess?.employeeNext != null ? int.Parse(data.employeeProcess.employeeNext.ToString()) : (int?)null;
            await _historyLogService.AddHistoryLog(log);
            await trans.CommitAsync();
            return Ok(new { trackingCode = newPackage.TrackingCode });
        }
        catch (JsonException je)
        {
            trans.Rollback();
            return BadRequest("Invalid JSON format: " + je.Message);
        }
        catch (Exception e)
        {
            trans.Rollback();
            return BadRequest("An error occurred: " + e.Message);
        }
    }

    #endregion

    #region Cancel a package
    [HttpPut]
    [Route("cancel/{id}")]
    public async Task<ActionResult> CancelPackage(int id)
    {
        try
        {
            using var reader = new StreamReader(Request.Body);
            string jsonBody = await reader.ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(jsonBody);
            bool result =  await _packageService.CancelPackage(id);
            Package package = await _packageService.GetPackageById(id);
            package.HistoryLogs.Add(new HistoryLog
            {
                PackageId = id,
                Step = EPackageStatus.Cancelled,
                HistoryNote = data.employeeProcess != null ? "Cancelled by employee"+ data.employeeProcess.employeeCode  : "Cancelled by user",
                EmployeeId = data.employeeProcess != null ? data.userId : null,
            });
            await _db.SaveChangesAsync();
            if (result)
            {
                return Ok();
            }
            return BadRequest("Package cancel failed!");
        }
        catch (Exception e)
        {
            return BadRequest("An error occurred: " + e.Message);
        }
    }
    #endregion

    #region Update package 
    [HttpPut]
    [Route("addPickup/{id}")]
    public async Task<ActionResult> AddPickup(int id)
    {
        using var reader = new StreamReader(Request.Body);
        string jsonBody = await reader.ReadToEndAsync();
        dynamic data = JsonConvert.DeserializeObject(jsonBody);
        if(data is null) return BadRequest("Invalid JSON format");
        if(data.action == "addPickup" && data.employeeProcess?.employeeNext != null)
        {
          bool result = _packageService.AddPickup(id, data.employeeProcess.employeeNext);
            if (!result)
            {
                return BadRequest("Add Pickup failed!");
            }
        }
        return Ok(new { message = "Add Pickup is successfuly!" });
    }

    #endregion
}