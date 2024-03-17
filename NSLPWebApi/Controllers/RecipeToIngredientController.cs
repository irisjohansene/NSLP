using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSLPWebApi.Dto;
using NSLPWebApi.DTO;
using NSLPWebApi.Models;
using NSLPWebApi.Services.RecipeToIngredientService;

namespace NSLPWebApi.Controllers
{
    [EnableCors("AllowedOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeToIngredientController : ControllerBase
    {
        private readonly IRecipeToIngredientService _rtiService;
        private readonly IMapper _mapper;

        public RecipeToIngredientController(IRecipeToIngredientService menuTypeService, IMapper mapper)
        {
            _rtiService = menuTypeService;
            _mapper = mapper;
        }

        [HttpGet("GetAllRecipeToIngredient")]
        public async Task<IActionResult> GetAllRecipeToIngredient()
        {
            try
            {
                var apiResponse = new APIResponseModelDto<List<RecipeToIngredient>>();
                var ing = await _rtiService.GetAllRecipeToIngredientAsync();

                apiResponse.Data = ing;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddRecipeToIngredient")]
        public async Task<IActionResult> AddRecipeToIngredient(RecipeToIngredientDto model)
        {
            var apiResponse = new APIResponseModelDto<RecipeToIngredient>();
            var ingModel = _mapper.Map<RecipeToIngredient>(model);

            try
            {
                await _rtiService.AddRecipeToIngredientAsync(ingModel);

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

        [HttpPost("UpdateRecipeToIngredient")]
        public async Task<IActionResult> UpdateRecipeToIngredient(RecipeToIngredientDto model)
        {
            var apiResponse = new APIResponseModelDto<RecipeToIngredient>();
            var ingModel = _mapper.Map<RecipeToIngredient>(model);

            try
            {
                await _rtiService.UpdateRecipeToIngredientAsync(ingModel);

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

        [HttpPost("RemoveRecipeToIngredient")]
        public async Task<IActionResult> RemoveRecipeToIngredient(RecipeToIngredientDto model)
        {
            var apiResponse = new APIResponseModelDto<RecipeToIngredient>();
            var ingModel = _mapper.Map<RecipeToIngredient>(model);

            try
            {
                await _rtiService.RemoveRecipeToIngredientAsync(ingModel);

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

        [HttpGet("GetAllRecipeToIngredientByRecipeId/{recipeId}")]
        public async Task<IActionResult> GetAllRecipeToIngredientByRecipeId(int recipeId)
        {
            try
            {
                var apiResponse = new APIResponseModelDto<List<RecipeToIngredient>>();
                var ing = await _rtiService.GetAllRecipeToIngredientByRecipeIdAsync(recipeId);

                apiResponse.Data = ing;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
