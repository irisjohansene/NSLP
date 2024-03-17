using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSLPWebApi.Dto;
using NSLPWebApi.DTO;
using NSLPWebApi.Services.UtilityService;

namespace NSLPWebApi.Controllers
{
    [EnableCors("AllowedOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class UtilityController : ControllerBase
    {
        private readonly IUtilityService _utilityService;

        public UtilityController(IUtilityService utilityService)
        {
            _utilityService = utilityService;
        }

        [HttpGet("GetAllPredefinedTable")]
        public async Task<IActionResult> GetAllPredefinedTable()
        {
            var apiResponse = new APIResponseModelDto<PredefinedTableDto>();
            var pt = await _utilityService.GetAllPredefinedTable();

            if (pt != null)
            {
                apiResponse.Data = pt;
                apiResponse.Error = false;
                
            }
            return Ok(apiResponse);
        }
    }
}
