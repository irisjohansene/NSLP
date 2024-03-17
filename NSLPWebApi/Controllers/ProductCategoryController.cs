using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSLPWebApi.Dto;
using NSLPWebApi.DTO;
using NSLPWebApi.Models;
using NSLPWebApi.Services.ProductCategoryService;

namespace NSLPWebApi.Controllers
{
    [EnableCors("AllowedOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly IProductCategoryService _productCategoryService;
        private readonly IMapper _mapper;

        public ProductCategoryController(IProductCategoryService productCategoryService, IMapper mapper)
        {
            _productCategoryService = productCategoryService;
            _mapper = mapper;
        }

        [HttpGet("GetAllProductCategory")]
        public async Task<IActionResult> GetAllProductCategory()
        {
            try
            {
                var apiResponse = new APIResponseModelDto<List<ProductCategory>>();
                var ing = await _productCategoryService.GetAllProductCategoryAsync();

                apiResponse.Data = ing;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddProductCategory")]
        public async Task<IActionResult> AddProductCategory(ProductCategoryDto model)
        {
            var apiResponse = new APIResponseModelDto<ProductCategory>();
            var ingModel = _mapper.Map<ProductCategory>(model);

            try
            {
                await _productCategoryService.AddProductCategoryAsync(ingModel);

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

        [HttpPost("UpdateProductCategory")]
        public async Task<IActionResult> UpdateProductCategory(ProductCategoryDto model)
        {
            var apiResponse = new APIResponseModelDto<ProductCategory>();
            var ingModel = _mapper.Map<ProductCategory>(model);

            try
            {
                await _productCategoryService.UpdateProductCategoryAsync(ingModel);

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

        [HttpPost("RemoveProductCategory")]
        public async Task<IActionResult> RemoveProductCategory(ProductCategoryDto model)
        {
            var apiResponse = new APIResponseModelDto<ProductCategory>();
            var ingModel = _mapper.Map<ProductCategory>(model);

            try
            {
                await _productCategoryService.RemoveProductCategoryAsync(ingModel);

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
