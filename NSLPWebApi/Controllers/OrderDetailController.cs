using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSLPWebApi.Dto;
using NSLPWebApi.DTO;
using NSLPWebApi.Models;
using NSLPWebApi.Services.OrderDetailService;

namespace NSLPWebApi.Controllers
{
    [EnableCors("AllowedOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailService _odService;
        private readonly IMapper _mapper;

        public OrderDetailController(IOrderDetailService odService, IMapper mapper)
        {
            _odService = odService;
            _mapper = mapper;
        }

        [HttpGet("GetAllOrderDetail")]
        public async Task<IActionResult> GetAllOrderDetail()
        {
            try
            {
                var apiResponse = new APIResponseModelDto<List<OrderDetail>>();
                var ing = await _odService.GetAllOrderDetailAsync();

                apiResponse.Data = ing;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddOrderDetail")]
        public async Task<IActionResult> AddOrderDetail(OrderDetailDto model)
        {
            var apiResponse = new APIResponseModelDto<OrderDetail>();
            var ingModel = _mapper.Map<OrderDetail>(model);

            try
            {
                await _odService.AddOrderDetailAsync(ingModel);

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

        [HttpPost("UpdateOrderDetail")]
        public async Task<IActionResult> UpdateOrderDetail(OrderDetailDto model)
        {
            var apiResponse = new APIResponseModelDto<OrderDetail>();
            var ingModel = _mapper.Map<OrderDetail>(model);

            try
            {
                await _odService.UpdateOrderDetailAsync(ingModel);

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

        [HttpPost("RemoveOrderDetail")]
        public async Task<IActionResult> RemoveOrderDetail(OrderDetailDto model)
        {
            var apiResponse = new APIResponseModelDto<OrderDetail>();
            var ingModel = _mapper.Map<OrderDetail>(model);

            try
            {
                await _odService.RemoveOrderDetailAsync(ingModel);

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
