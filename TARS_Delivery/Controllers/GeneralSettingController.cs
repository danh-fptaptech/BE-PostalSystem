using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Services;

namespace TARS_Delivery.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GeneralSettingController : ControllerBase
{
    private readonly IGeneralSettingService _generalSettingService;
    
    public GeneralSettingController(IGeneralSettingService generalSettingService)
    {
        _generalSettingService = generalSettingService;
    }
    
    
}