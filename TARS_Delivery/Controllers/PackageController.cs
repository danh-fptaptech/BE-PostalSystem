using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;
using TARS_Delivery.Services;

namespace TARS_Delivery.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PackageController : ControllerBase
{
    private readonly IPackageService _packageService;
    private readonly IItemService _itemService;
    private readonly IHistoryLogService _historyLogService;

    public PackageController(IPackageService packageService, IItemService itemService,
        IHistoryLogService historyLogService)
    {
        _packageService = packageService;
        _itemService = itemService;
        _historyLogService = historyLogService;
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

    #region Get a package by tracking number

    [HttpGet]
    [Route("getbytracking/{trackingNumber}")]
    public async Task<ActionResult<Package>> GetPackageByTrackingNumber(string trackingNumber)
    {
        Package package = await _packageService.GetPackageByTrackingNumber(trackingNumber);
        if (package == null)
        {
            return NotFound();
        }

        return Ok(package);
    }

    #endregion

    #region Create a new package by user

    [HttpPost]
    [Route("add")]
    public async Task<ActionResult> AddPackage()
    {
        try
        {
            using var reader = new StreamReader(Request.Body);
            string jsonBody = await reader.ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(jsonBody);
            RDTOPackage package = new RDTOPackage();
            //Info sender
            package.NameFrom = data.sender.fullName;
            package.PhoneFrom = data.sender.phoneNumber;
            package.AddressFrom = data.sender.address + " Ward: " + data.sender.ward + " District: " +
                                  data.sender.district + " Province: " + data.sender.province;
            package.PostalCodeFrom = data.sender.postalCode;
            //Info receiver
            package.NameTo = data.receiver.fullName;
            package.PhoneTo = data.receiver.phoneNumber;
            package.AddressTo = data.receiver.address + " Ward: " + data.receiver.ward + " District: " +
                                data.receiver.district + " Province: " + data.receiver.province;
            package.PostalCodeTo = data.receiver.postalCode;
            //Info package
            package.ServiceId = data.service.serviceId;
            package.PackageNote = data.packageNote;
            package.PackageSize = data.packageSize ? data.packageSize.ToString() : null;
            package.EmployeeCode = data.submitBy.employeeCode || null;
            package.UserId = data.submitBy.employeeCode ? null : data.submitBy.userId;
            package.EmployeeId = data.submitBy.employeeCode ? data.submitBy.employeeId : null;
            package.TotalFee = decimal.Parse(data.fee);
            package.COD = int.Parse(data.cod);
            package.Step = data.submitBy.employeeCode ? EPackageStatus.Created : EPackageStatus.WaitingForPickup;
            //Add package by service
            var newPackage = await _packageService.AddPackage(package);
            foreach (var item in data.items)
            {
                Item newItem = new Item();
                newItem.ItemName = item.itemName;
                newItem.ItemQuantity = int.Parse(item.itemQuantity);
                newItem.ItemWeight = int.Parse(item.itemWeight);
                newItem.ItemValue = decimal.Parse(item.itemValue);
                newItem.PackageId = newPackage.Id;
                newItem.ItemType = data.type == "document" ? EItemType.Document : EItemType.Pack;
                var result = await _itemService.AddItem(newItem);
                newPackage.Items.Add(result);
            }

            HistoryLog log = new HistoryLog();
            log.PackageId = newPackage.Id;
            log.EmployeeId = data.submitBy.employeeCode ? data.submitBy.id : null;
            log.Step = data.submitBy.employeeCode ? EPackageStatus.Created : EPackageStatus.WaitingForPickup;
            log.HistoryNote = data.employeeProcess?.historyNote||null;
            log.Photos = data.employeeProcess?.photo||null;
            log.EmployeeNextStep = data.employeeProcess?.employeeNext ? int.Parse(data.employeeProcess?.employeeNext) : null;
            var resulthl =  _historyLogService.AddHistoryLog(log);
            return Ok(newPackage);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    #endregion
}