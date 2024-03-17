using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NSLPWebApi.Dto;
using NSLPWebApi.DTO;
using NSLPWebApi.Models;
using NSLPWebApi.Services.MenuService;

namespace NSLPWebApi.Controllers
{
    [EnableCors("AllowedOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuTypeService;
        private readonly IMapper _mapper;

        public MenuController(IMenuService menuTypeService, IMapper mapper)
        {
            _menuTypeService = menuTypeService;
            _mapper = mapper;
        }

        [HttpGet("GetAllMenu")]
        public async Task<IActionResult> GetAllMenu()
        {
            try
            {
                var apiResponse = new APIResponseModelDto<List<Menu>>();
                var ing = await _menuTypeService.GetAllMenuAsync();

                apiResponse.Data = ing;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetMenuByMenuId/{menuId}")]
        public async Task<IActionResult> GetMenuByMenuId(int menuId)
        {
            try
            {
                var apiResponse = new APIResponseModelDto<Menu>();
                var ing = await _menuTypeService.GetMenuByMenuIdAsync(menuId);

                apiResponse.Data = ing;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddMenu")]
        public async Task<IActionResult> AddMenu(MenuDto model)
        {
            var apiResponse = new APIResponseModelDto<Menu>();
            var ingModel = _mapper.Map<Menu>(model);

            try
            {
                var res = await _menuTypeService.AddMenuAsync(ingModel);
                if(res != null)
                {
                    apiResponse.Data = res;
                    apiResponse.Message = "Success";
                    apiResponse.Error = false;
                }
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                apiResponse.Message = ex.Message;
                apiResponse.Error = true;
                return BadRequest(apiResponse);
            }
        }

        [HttpPost("UpdateMenu")]
        public async Task<IActionResult> UpdateMenu(MenuDto model)
        {
            var apiResponse = new APIResponseModelDto<Menu>();
            var ingModel = _mapper.Map<Menu>(model);

            try
            {
                await _menuTypeService.UpdateMenuAsync(ingModel);

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

        [HttpPost("RemoveMenu")]
        public async Task<IActionResult> RemoveMenu(MenuDto model)
        {
            var apiResponse = new APIResponseModelDto<Menu>();
            var ingModel = _mapper.Map<Menu>(model);

            try
            {
                await _menuTypeService.RemoveMenuAsync(ingModel);

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
