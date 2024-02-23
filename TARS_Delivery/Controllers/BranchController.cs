using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Services;

namespace TARS_Delivery.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BranchController : ControllerBase
{
  private readonly IBranchService _branchService;

  public BranchController(IBranchService branchService)
  {
    _branchService = branchService;
  }

  #region Get all branches

  [HttpGet]
  [Route("all")]
  public async Task<ActionResult<ICollection<SDTOBranch>>> GetAllBranches()
  {
    try
    {
      return Ok(await _branchService.GetAllBranches());
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  } 

  #endregion

  #region Get a branch by id
  [HttpGet]
  [Route("getbyid/{id}")]
  public async Task<ActionResult<Branch>> GetBranchById(int id)
  {
    Branch branch = await _branchService.GetBranchById(id);
    if (branch == null)
    {
      return NotFound();
    }
    return Ok(branch);
  }

  #endregion

  #region Create a new branch
  [HttpPost]
  [Route("add")]
  public async Task<ActionResult<Branch>> AddBranch(RDTOBranch branch)
  {
    try
    {
      Branch newBranch = await _branchService.AddBranch(branch);
      return Created($"/api/branch/{newBranch.Id}", newBranch);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  #endregion

  #region Update a branch
  [HttpPut]
  [Route("update/{id}")]
  public async Task<ActionResult<Branch>> UpdateBranch(int id, RDTOBranch branch)
  {
    try
    {
      if(ModelState.IsValid == false)
      {
        return BadRequest(ModelState);
      }
      Branch updatedBranch = await _branchService.UpdateBranch(id, branch);
      return Ok(updatedBranch);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  } 

  #endregion

  #region Toggle branch status
  [HttpPatch]
  [Route("togglestatus/{id}")]
  public async Task<ActionResult<bool>> ToggleBranchStatus(int id)
  {
    try
    {
      return Ok( await _branchService.ToggleBranchStatus(id));
    }
    catch (Exception e)
    {
      if(e.Message == "Branch not found")
      {
        return NotFound("Branch not found");
      }

      return BadRequest(e.Message);
    }
  }
  #endregion

  #region Get all employees by branch id
  
  [HttpGet]
  [Route("employees/{id}")]
  public async Task<ActionResult<ICollection<Employee>>> GetAllEmployeesByBranchId(int id)
  {
    try
    {
      return Ok(await _branchService.GetAllEmployeesByBranchId(id));
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  #endregion

  #region Get all packages by branch id
  [HttpGet]
  [Route("packages/{id}")]
  public async Task<ActionResult<ICollection<Package>>> GetAllPackagesByBranchId(int id)
  {
    try
    {
      ICollection<Package> packages = await _branchService.GetAllPackagesByBranchId(id);
      return Ok(packages);
    }
    catch (Exception e)
    { 
      return BadRequest(e.Message);
    }
  }

  #endregion

  #region Get all items by branch id
  [HttpGet]
  [Route("items/{id}")]
  public async Task<ActionResult<ICollection<Item>>> GetAllItemsByBranchId(int id)
  {
    try
    {
      ICollection<Item> items = await _branchService.GetAllItemsByBranchId(id);
      return Ok(items);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  #endregion
}