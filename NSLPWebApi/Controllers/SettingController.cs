using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSLPWebApi.Dto;
using NSLPWebApi.DTO;
using NSLPWebApi.Models;
using NSLPWebApi.Services.SettingService;

namespace NSLPWebApi.Controllers
{
    [EnableCors("AllowedOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class SettingController : ControllerBase
    {
        private readonly ISettingService _settingService;
        private readonly IMapper _mapper;

        public SettingController(ISettingService settingService, IMapper mapper)
        {
            _settingService = settingService;
            _mapper = mapper;
        }

        [HttpGet("GetAllSetting")]
        public async Task<IActionResult> GetAllSetting()
        {
            try
            {
                var apiResponse = new APIResponseModelDto<List<Setting>>();
                var ing = await _settingService.GetAllSettingAsync();

                apiResponse.Data = ing;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddSetting")]
        public async Task<IActionResult> AddSetting(SettingDto model)
        {
            var apiResponse = new APIResponseModelDto<Setting>();
            var ingModel = _mapper.Map<Setting>(model);

            try
            {
                await _settingService.AddSettingAsync(ingModel);

                apiResponse.Data = ingModel;
                apiResponse.Error = false;

                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                apiResponse.Message = ex.Message;
                apiResponse.Error = true;
                return BadRequest(apiResponse);
            }
        }

        [HttpPost("UpdateSetting")]
        public async Task<IActionResult> UpdateSetting(SettingDto model)
        {
            var apiResponse = new APIResponseModelDto<Setting>();
            var ingModel = _mapper.Map<Setting>(model);

            try
            {
                await _settingService.UpdateSettingAsync(ingModel);

                apiResponse.Data = ingModel;
                apiResponse.Error = false;

                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                apiResponse.Message = ex.Message;
                apiResponse.Error = true;
                return BadRequest(apiResponse);
            }
        }

        [HttpPost("RemoveSetting")]
        public async Task<IActionResult> RemoveSetting(SettingDto model)
        {
            var apiResponse = new APIResponseModelDto<Setting>();
            var ingModel = _mapper.Map<Setting>(model);

            try
            {
                await _settingService.RemoveSettingAsync(ingModel);

                apiResponse.Data = ingModel;
                apiResponse.Error = false;

                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                apiResponse.Message = ex.Message;
                apiResponse.Error = true;
                return BadRequest(apiResponse);
            }
        }
    }
}
