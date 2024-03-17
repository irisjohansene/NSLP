using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSLPWebApi.Dto;
using NSLPWebApi.DTO;
using NSLPWebApi.Models;
using NSLPWebApi.Services.MenuToIngredientService;

namespace NSLPWebApi.Controllers
{
    [EnableCors("AllowedOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class MenuToIngredientOrRecipeController : ControllerBase
    {
        private readonly IMenuToIngredientOrRecipeService _menuTypeService;
        private readonly IMapper _mapper;

        public MenuToIngredientOrRecipeController(IMenuToIngredientOrRecipeService menuTypeService, IMapper mapper)
        {
            _menuTypeService = menuTypeService;
            _mapper = mapper;
        }

        [HttpGet("GetAllMenuToIngredientOrRecipe")]
        public async Task<IActionResult> GetAllMenuToIngredientOrRecipe()
        {
            try
            {
                var apiResponse = new APIResponseModelDto<List<MenuToIngredientOrRecipe>>();
                var ing = await _menuTypeService.GetAllMenuToIngredientOrRecipeAsync();

                apiResponse.Data = ing;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddMenuToIngredientOrRecipe")]
        public async Task<IActionResult> AddMenuToIngredientOrRecipe(IEnumerable<MenuToIngredientOrRecipeDto> model)
        {
            var apiResponse = new APIResponseModelDto<IEnumerable<MenuToIngredientOrRecipe>>();
            var ingModel = _mapper.Map<IEnumerable<MenuToIngredientOrRecipe>>(model);

            try
            {
                await _menuTypeService.AddMenuToIngredientOrRecipeAsync(ingModel);

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

        [HttpPost("AddOneMenuToIngredientOrRecipe")]
        public async Task<IActionResult> AddOneMenuToIngredientOrRecipe(MenuToIngredientOrRecipeDto model)
        {
            var apiResponse = new APIResponseModelDto<MenuToIngredientOrRecipe>();
            var ingModel = _mapper.Map<MenuToIngredientOrRecipe>(model);

            try
            {
                await _menuTypeService.AddOneMenuToIngredientOrRecipeAsync(ingModel);

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

        [HttpPost("UpdateMenuToIngredientOrRecipe")]
        public async Task<IActionResult> UpdateMenuToIngredient(MenuToIngredientOrRecipeDto model)
        {
            var apiResponse = new APIResponseModelDto<MenuToIngredientOrRecipe>();
            var ingModel = _mapper.Map<MenuToIngredientOrRecipe>(model);

            try
            {
                await _menuTypeService.UpdateMenuToIngredientOrRecipeAsync(ingModel);

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

        [HttpPost("RemoveMenuToIngredientOrRecipe")]
        public async Task<IActionResult> RemoveMenuToIngredient(MenuToIngredientOrRecipeDto model)
        {
            var apiResponse = new APIResponseModelDto<MenuToIngredientOrRecipe>();
            var ingModel = _mapper.Map<MenuToIngredientOrRecipe>(model);

            try
            {
                await _menuTypeService.RemoveMenuToIngredientOrRecipeAsync(ingModel);

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

        [HttpGet("GetAllDataByDateAndId/{dateTime}/{menutypeid}")]
        public async Task<IActionResult> GetAllDataByDateAndId(DateTime dateTime, int menutypeid)
        {
            var apiResponse = new APIResponseModelDto<List<MenuToIngredientOrRecipe>>();

            try
            {
                var res = await _menuTypeService.GetAllDataByDateAndIdAsync(dateTime, menutypeid);

                apiResponse.Data = res;
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
