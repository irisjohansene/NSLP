using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSLPWebApi.Dto;
using NSLPWebApi.DTO;
using NSLPWebApi.Models;
using NSLPWebApi.Services.ComponentTypeService;

namespace NSLPWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentTypeController : ControllerBase
    {
        private readonly IComponentTypeService _typeService;
        private readonly IMapper _mapper;

        public ComponentTypeController(IComponentTypeService typeService, IMapper mapper)
        {
            _typeService = typeService;
            _mapper = mapper;
        }

        [HttpGet("GetAllComponentType")]
        public async Task<IActionResult> GetAllComponentType()
        {
            try
            {
                var apiResponse = new APIResponseModelDto<List<ComponentType>>();
                var type = await _typeService.GetAllComponentTypeAsync();

                apiResponse.Data = type;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddComponentType")]
        public async Task<IActionResult> AddComponentType(ComponentTypeDto model)
        {
            var apiResponse = new APIResponseModelDto<ComponentType>();
            var typeModel = _mapper.Map<ComponentType>(model);

            try
            {
                await _typeService.AddComponentTypeAsync(typeModel);

                apiResponse.Data = typeModel;
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

        [HttpPost("UpdateComponentType")]
        public async Task<IActionResult> UpdateComponentType(ComponentTypeDto model)
        {
            var apiResponse = new APIResponseModelDto<ComponentType>();
            var typeModel = _mapper.Map<ComponentType>(model);

            try
            {
                await _typeService.UpdateComponentTypeAsync(typeModel);

                apiResponse.Data = typeModel;
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

        [HttpPost("RemoveComponentType")]
        public async Task<IActionResult> RemoveComponentType(ComponentTypeDto model)
        {
            var apiResponse = new APIResponseModelDto<ComponentType>();
            var typeModel = _mapper.Map<ComponentType>(model);

            try
            {
                await _typeService.RemoveComponentTypeAsync(typeModel);

                apiResponse.Data = typeModel;
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
