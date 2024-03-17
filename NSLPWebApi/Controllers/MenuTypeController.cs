using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSLPWebApi.Dto;
using NSLPWebApi.DTO;
using NSLPWebApi.Models;
using NSLPWebApi.Services.MenuTypeService;

namespace NSLPWebApi.Controllers
{
    [EnableCors("AllowedOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class MenuTypeController : ControllerBase
    {
        private readonly IMenuTypeService _menuTypeService;
        private readonly IMapper _mapper;

        public MenuTypeController(IMenuTypeService menuTypeService, IMapper mapper)
        {
            _menuTypeService = menuTypeService;
            _mapper = mapper;
        }

        [HttpGet("GetAllMenuType")]
        public async Task<IActionResult> GetAllMenuType()
        {
            try
            {
                var apiResponse = new APIResponseModelDto<List<MenuType>>();
                var ing = await _menuTypeService.GetAllMenuTypeAsync();

                apiResponse.Data = ing;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddMenuType")]
        public async Task<IActionResult> AddMenuType(MenuTypeDto model)
        {
            var apiResponse = new APIResponseModelDto<MenuType>();
            var ingModel = _mapper.Map<MenuType>(model);

            try
            {
                await _menuTypeService.AddMenuTypeAsync(ingModel);

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

        [HttpPost("UpdateMenuType")]
        public async Task<IActionResult> UpdateMenuType(MenuTypeDto model)
        {
            var apiResponse = new APIResponseModelDto<MenuType>();
            var ingModel = _mapper.Map<MenuType>(model);

            try
            {
                await _menuTypeService.UpdateMenuTypeAsync(ingModel);

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

        [HttpPost("RemoveMenuType")]
        public async Task<IActionResult> RemoveMenuType(MenuTypeDto model)
        {
            var apiResponse = new APIResponseModelDto<MenuType>();
            var ingModel = _mapper.Map<MenuType>(model);

            try
            {
                await _menuTypeService.RemoveMenuTypeAsync(ingModel);

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
