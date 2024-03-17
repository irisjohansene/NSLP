using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NSLPWebApi.Dto;
using NSLPWebApi.DTO;
using NSLPWebApi.Models;
using NSLPWebApi.Services.IngredientTypeService;

namespace NSLPWebApi.Controllers
{
    [EnableCors("AllowedOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientTypeController : ControllerBase
    {
        private readonly IIngredientTypeService _ingredientService;
        private readonly IMapper _mapper;

        public IngredientTypeController(IIngredientTypeService ingredientService, IMapper mapper)
        {
            _ingredientService = ingredientService;
            _mapper = mapper;
        }

        [HttpGet("GetAllIngredientType")]
        public async Task<IActionResult> GetAllIngredientType()
        {
            try
            {
                var apiResponse = new APIResponseModelDto<List<IngredientType>>();
                var ing = await _ingredientService.GetAllIngredientTypeAsync();

                apiResponse.Data = ing;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddIngredientType")]
        public async Task<IActionResult> AddIngredientType(IngredientTypeDto model)
        {
            var apiResponse = new APIResponseModelDto<IngredientType>();
            var ingModel = _mapper.Map<IngredientType>(model);

            try
            {
                await _ingredientService.AddIngredientTypeAsync(ingModel);

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

        [HttpPost("UpdateIngredientType")]
        public async Task<IActionResult> UpdateIngredientType(IngredientTypeDto model)
        {
            var apiResponse = new APIResponseModelDto<IngredientType>();
            var ingModel = _mapper.Map<IngredientType>(model);

            try
            {
                await _ingredientService.UpdateIngredientTypeAsync(ingModel);

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

        [HttpPost("RemoveIngredientType")]
        public async Task<IActionResult> RemoveIngredientType(IngredientTypeDto model)
        {
            var apiResponse = new APIResponseModelDto<IngredientType>();
            var ingModel = _mapper.Map<IngredientType>(model);

            try
            {
                await _ingredientService.RemoveIngredientTypeAsync(ingModel);

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
