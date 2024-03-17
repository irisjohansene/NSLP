using NSLPWasm.Dto;
using NSLPWasm.DTO;
using NSLPWasm.Services.APIService;

namespace NSLPWasm.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IAPIService _apiService;

        APIResponseModel<List<OrderDto>> respList = new APIResponseModel<List<OrderDto>>();
        APIResponseModel<OrderDto> resp = new APIResponseModel<OrderDto>();

        public OrderService(IAPIService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<OrderDto>> GetAllOrder()
        {
            respList = await _apiService.InvokeGetAsync<APIResponseModel<List<OrderDto>>>($"/api/Order/GetAllOrder");
            return respList.Data;
        }

        public async Task<OrderDto> GetOrderByOrderId(int orderId)
        {
            resp = await _apiService.InvokeGetAsync<APIResponseModel<OrderDto>>($"api/Order/GetOrderByOrderId/{orderId}");
            return resp.Data;
        }

        public async Task<OrderDto> AddOrder(OrderDto model)
        {
            resp.Data = await _apiService.InvokePost("/api/Order/AddOrder", model);
            return resp.Data;
        }

        public async Task<OrderDto> UpdateOrder(OrderDto model)
        {
            resp.Data = await _apiService.InvokePost("api/Order/UpdateOrder", model);
            return resp.Data;
        }

        public async Task<OrderDto> RemoveOrder(OrderDto model)
        {
            resp.Data = await _apiService.InvokePost("api/Order/RemoveOrder", model);
            return resp.Data;
        }
    }
}
