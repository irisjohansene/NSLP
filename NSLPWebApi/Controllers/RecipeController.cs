using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSLPWebApi.Dto;
using NSLPWebApi.DTO;
using NSLPWebApi.Models;
using NSLPWebApi.Services.RecipeService;

namespace NSLPWebApi.Controllers
{
    [EnableCors("AllowedOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _recipeService;
        private readonly IMapper _mapper;

        public RecipeController(IRecipeService recipeService, IMapper mapper)
        {
            _recipeService = recipeService;
            _mapper = mapper;
        }

        [HttpGet("GetAllRecipe")]
        public async Task<IActionResult> GetAllRecipe()
        {
            try
            {
                var apiResponse = new APIResponseModelDto<List<Recipe>>();
                var ing = await _recipeService.GetAllRecipeAsync();

                apiResponse.Data = ing;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetRecipeByRecipeId/{recipeId}")]
        public async Task<IActionResult> GetRecipeByRecipeId(int recipeId)
        {
            try
            {
                var apiResponse = new APIResponseModelDto<Recipe>();
                var ing = await _recipeService.GetRecipeByRecipeIdAsync(recipeId);

                apiResponse.Data = ing;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddRecipe")]
        public async Task<IActionResult> AddRecipe(RecipeDto model)
        {
            var apiResponse = new APIResponseModelDto<Recipe>();
            var ingModel = _mapper.Map<Recipe>(model);

            try
            {
                int? recipeId = await _recipeService.AddRecipeAsync(ingModel);

                if (recipeId.HasValue)
                {
                    ingModel.RecipeId = recipeId.Value; // Assign the generated RecipeId to the model

                    apiResponse.Data = ingModel;
                    apiResponse.Error = false;

                    return Ok(apiResponse);
                }
                else
                {
                    apiResponse.Message = "Failed to add recipe.";
                    apiResponse.Error = true;
                    return BadRequest(apiResponse);
                }
            }
            catch (Exception ex)
            {
                apiResponse.Message = ex.Message;
                apiResponse.Error = true;
                return BadRequest(apiResponse);
            }
        }



        [HttpPost("UpdateRecipe")]
        public async Task<IActionResult> UpdateRecipe(RecipeDto model)
        {
            var apiResponse = new APIResponseModelDto<Recipe>();
            var ingModel = _mapper.Map<Recipe>(model);

            try
            {
                await _recipeService.UpdateRecipeAsync(ingModel);

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

        [HttpPost("RemoveRecipe")]
        public async Task<IActionResult> RemoveRecipe(RecipeDto model)
        {
            var apiResponse = new APIResponseModelDto<Recipe>();
            var ingModel = _mapper.Map<Recipe>(model);

            try
            {
                await _recipeService.RemoveRecipeAsync(ingModel);

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
