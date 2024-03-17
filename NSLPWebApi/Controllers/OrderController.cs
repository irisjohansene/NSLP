using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSLPWebApi.Dto;
using NSLPWebApi.DTO;
using NSLPWebApi.Models;
using NSLPWebApi.Services.OrderService;

namespace NSLPWebApi.Controllers
{
    [EnableCors("AllowedOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpGet("GetAllOrder")]
        public async Task<IActionResult> GetAllOrder()
        {
            try
            {
                var apiResponse = new APIResponseModelDto<List<Order>>();
                var ing = await _orderService.GetAllOrderAsync();

                apiResponse.Data = ing;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetOrderByOrderId/{orderId}")]
        public async Task<IActionResult> GetOrderByOrderId(int orderId)
        {
            try
            {
                var apiResponse = new APIResponseModelDto<Order>();
                var ing = await _orderService.GetOrderByOrderIdAsync(orderId);

                apiResponse.Data = ing;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddOrder")]
        public async Task<IActionResult> AddOrder(OrderDto model)
        {
            var apiResponse = new APIResponseModelDto<Order>();
            var ingModel = _mapper.Map<Order>(model);

            try
            {
                await _orderService.AddOrderAsync(ingModel);

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

        [HttpPost("UpdateOrder")]
        public async Task<IActionResult> UpdateOrder(OrderDto model)
        {
            var apiResponse = new APIResponseModelDto<Order>();
            var ingModel = _mapper.Map<Order>(model);

            try
            {
                await _orderService.UpdateOrderAsync(ingModel);

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

        [HttpPost("RemoveOrder")]
        public async Task<IActionResult> RemoveOrder(OrderDto model)
        {
            var apiResponse = new APIResponseModelDto<Order>();
            var ingModel = _mapper.Map<Order>(model);

            try
            {
                await _orderService.RemoveOrderAsync(ingModel);

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
