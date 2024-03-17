using NSLPWasm.Dto;
using NSLPWasm.DTO;
using NSLPWasm.Services.APIService;

namespace NSLPWasm.Services.OrderDetailService
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IAPIService _apiService;

        APIResponseModel<List<OrderDetailDto>> respList = new APIResponseModel<List<OrderDetailDto>>();
        APIResponseModel<OrderDetailDto> resp = new APIResponseModel<OrderDetailDto>();

        public OrderDetailService(IAPIService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<OrderDetailDto>> GetAllOrderDetail()
        {
            respList = await _apiService.InvokeGetAsync<APIResponseModel<List<OrderDetailDto>>>($"/api/OrderDetail/GetAllOrderDetail");
            return respList.Data;
        }

        public async Task<OrderDetailDto> AddOrderDetail(OrderDetailDto model)
        {
            resp.Data = await _apiService.InvokePost("/api/OrderDetail/AddOrderDetail", model);
            return resp.Data;
        }

        public async Task<OrderDetailDto> UpdateOrderDetail(OrderDetailDto model)
        {
            resp.Data = await _apiService.InvokePost("api/OrderDetail/UpdateOrderDetail", model);
            return resp.Data;
        }

        public async Task<OrderDetailDto> RemoveOrderDetail(OrderDetailDto model)
        {
            resp.Data = await _apiService.InvokePost("api/OrderDetail/RemoveOrderDetail", model);
            return resp.Data;
        }
    }
}
