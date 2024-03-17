using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSLPWebApi.Constants;
using NSLPWebApi.Dto;
using NSLPWebApi.DTO;
using NSLPWebApi.Models;
using NSLPWebApi.Services.IngredientService;
using Serilog;

namespace NSLPWebApi.Controllers
{
    [EnableCors("AllowedOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;
        private readonly IMapper _mapper;

        public IngredientController(IIngredientService ingredientService, IMapper mapper)
        {
            _ingredientService = ingredientService;
            _mapper = mapper;
        }

        [HttpGet("GetAllIngredient")]
        public async Task<IActionResult> GetAllIngredient()
        {
            try
            {
                var apiResponse = new APIResponseModelDto<List<Ingredient>>();
                var ing = await _ingredientService.GetAllIngredientAsync();

                apiResponse.Data = ing;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddIngredient")]
        public async Task<IActionResult> AddIngredient(IngredientDto model)
        {
            var apiResponse = new APIResponseModelDto<Ingredient>();
            var ingModel = _mapper.Map<Ingredient>(model);

            try
            {
                await _ingredientService.AddIngredientAsync(ingModel);

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

        [HttpPost("UpdateIngredient")]
        public async Task<IActionResult> UpdateIngredient(IngredientDto model)
        {
            var apiResponse = new APIResponseModelDto<Ingredient>();
            var ingModel = _mapper.Map<Ingredient>(model);

            try
            {
                await _ingredientService.UpdateIngredientAsync(ingModel);

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

        [HttpPost("RemoveIngredient")]
        public async Task<IActionResult> RemoveIngredient(IngredientDto model)
        {
            var apiResponse = new APIResponseModelDto<Ingredient>();
            var ingModel = _mapper.Map<Ingredient>(model);

            try
            {
                await _ingredientService.RemoveIngredientAsync(ingModel);

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
