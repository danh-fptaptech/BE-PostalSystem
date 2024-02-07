using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeeCustomController : ControllerBase
    {
        private readonly IFeeCustomRepository _feeCustomRepository;
        public FeeCustomController(IFeeCustomRepository feeCustomRepository)
        {
            _feeCustomRepository = feeCustomRepository;
        }
        //Get all Fees
        [HttpGet]
        public async Task<ActionResult<ICollection<FeeCustom>>> GetAllFees()
        {
            try
            {
                var fees = await _feeCustomRepository.GetAllFees();
                return Ok(fees);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //Get Fee by Id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeeById(int id)
        {
            try
            {
                var fee = await _feeCustomRepository.GetFeeById(id);
                return Ok(fee);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //Add Fee
        [HttpPost]
        public async Task<IActionResult> CreateFee(FeeCustom fee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _feeCustomRepository.CreateFee(fee);
                    return Ok("Fee added successfully");
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
                }
            }
            return BadRequest("Invalid model");
        }
        //Update Fee
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFee(int id, FeeCustom fee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _feeCustomRepository.UpdateFee(id, fee);
                    return Ok("Fee updated successfully");
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
                }
            }
            return BadRequest("Invalid model");
        }
        //Change Status
        [HttpPut("ChangeStatus/{id}")]
        public async Task<IActionResult> ChangeStatus(int id)
        {
            try
            {
                await _feeCustomRepository.ChangeStatus(id);
                return Ok("Status changed successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //Get Fee by Postal Code
        [HttpGet("GetFeeByPostalCode/{postalCodeFrom}/{postalCodeTo}")]
        public async Task<IActionResult> GetFeeByPostalCode(string postalCodeFrom, string postalCodeTo)
        {
            try
            {
                var fee = await _feeCustomRepository.GetFeeByPostalCode(postalCodeFrom, postalCodeTo);
                if (fee != null)
                {
                    return Ok(fee);
                }
                return NotFound("Fee not found");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
