using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;
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
        [HttpGet("ChangeStatus/{id}")]
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
        //Get Fee by Postal Code and Weight
        [HttpGet("GetFeeByPostalCodeWeight/{postalCodeFrom}/{postalCodeTo}/{weight}")]
        public async Task<IActionResult> GetFeeByPostalCodeWeight(string postalCodeFrom, string postalCodeTo, int weight)
        {
            try
            {
                var fees = await _feeCustomRepository.GetFeeByPostalCodeWeight(postalCodeFrom, postalCodeTo, weight);
                if (fees != null)
                {
                    return Ok(fees);
                }
                return NotFound("Fee not found");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //Add or Update Fee
        [HttpPost("CreateUpdateFee/{postalCodeFrom}/{postalCodeTo}")]
        public async Task<IActionResult> CreateUpdateFee(string postalCodeFrom, string postalCodeTo, FeeCustom fee)
        {
/*            var listFeeCustomCreated = await GetFeeByPostalCode(postalCodeFrom, postalCodeTo);*/
            List<FeeCustom> listFeeCustomCreated = await _feeCustomRepository.GetFeeByPostalCode(postalCodeFrom, postalCodeTo);
            var newItem = new FeeCustom
            {
                ServiceId = fee.ServiceId,
                LocationIdFrom = fee.LocationIdFrom,
                LocationIdTo = fee.LocationIdTo,
                OverWeightCharge = fee.OverWeightCharge,
                FeeCharge = fee.FeeCharge,
                TimeProcess = fee.TimeProcess,
                Status = EStatusData.Active
            };

            if (listFeeCustomCreated.Count > 0)
            {
                
                foreach (var item in listFeeCustomCreated)
                {
                    if (item.ServiceId == fee.ServiceId)
                    {
                        item.OverWeightCharge = fee.OverWeightCharge;
                        item.TimeProcess = fee.TimeProcess;
                        await _feeCustomRepository.UpdateFee(item.Id, item);
                        return Ok("Fee updated successfully");
                    }
                }

                await _feeCustomRepository.CreateFee(newItem);
                return Ok("Fee added successfully");
            }
            else
            {
                await _feeCustomRepository.CreateFee(newItem);
                return Ok("Fee added successfully");
            }
        }
        //Get all Fees Custom
        [HttpGet("GetAllFeesCustom")]
        public async Task<IActionResult> GetAllFeesCustom()
        {
            try
            {
                var fees = await _feeCustomRepository.GetAllFeesCustom();
                return Ok(fees);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
