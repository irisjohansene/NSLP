using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSLPWebApi.Dto;
using NSLPWebApi.DTO;
using NSLPWebApi.Models;
using NSLPWebApi.Services.ComponentSubTypeService;

namespace NSLPWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentSubTypeController : ControllerBase
    {
        private readonly IComponentSubTypeService _subtypeService;
        private readonly IMapper _mapper;

        public ComponentSubTypeController(IComponentSubTypeService subtypeService, IMapper mapper)
        {
            _subtypeService = subtypeService;
            _mapper = mapper;
        }

        [HttpGet("GetAllComponentSubType")]
        public async Task<IActionResult> GetAllComponentSubType()
        {
            try
            {
                var apiResponse = new APIResponseModelDto<List<ComponentSubType>>();
                var subtypes = await _subtypeService.GetAllComponentSubTypeAsync();

                apiResponse.Data = subtypes;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAllComponentSubTypeByType/{type}")]
        public async Task<IActionResult> GetAllComponentSubTypeByType(int type)
        {
            try
            {
                var apiResponse = new APIResponseModelDto<List<ComponentSubType>>();
                var subtypes = await _subtypeService.GetAllComponentSubTypeByTypeAsync(type);

                apiResponse.Data = subtypes;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddComponentSubType")]
        public async Task<IActionResult> AddComponentSubType(ComponentSubTypeDto model)
        {
            var apiResponse = new APIResponseModelDto<ComponentSubType>();
            var subtypeModel = _mapper.Map<ComponentSubType>(model);

            try
            {
                await _subtypeService.AddComponentSubTypeAsync(subtypeModel);

                apiResponse.Data = subtypeModel;
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

        [HttpPost("UpdateComponentSubType")]
        public async Task<IActionResult> UpdateComponentSubType(ComponentSubTypeDto model)
        {
            var apiResponse = new APIResponseModelDto<ComponentSubType>();
            var subtypeModel = _mapper.Map<ComponentSubType>(model);

            try
            {
                await _subtypeService.UpdateComponentSubTypeAsync(subtypeModel);

                apiResponse.Data = subtypeModel;
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

        [HttpPost("RemoveComponentSubType")]
        public async Task<IActionResult> RemoveComponentSubType(ComponentSubTypeDto model)
        {
            var apiResponse = new APIResponseModelDto<ComponentSubType>();
            var subtypeModel = _mapper.Map<ComponentSubType>(model);

            try
            {
                await _subtypeService.RemoveComponentSubTypeAsync(subtypeModel);

                apiResponse.Data = subtypeModel;
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
