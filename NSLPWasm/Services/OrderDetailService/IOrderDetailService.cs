using NSLPWasm.Dto;

namespace NSLPWasm.Services.OrderDetailService
{
    public interface IOrderDetailService
    {
        Task<OrderDetailDto> AddOrderDetail(OrderDetailDto model);
        Task<List<OrderDetailDto>> GetAllOrderDetail();
        Task<OrderDetailDto> RemoveOrderDetail(OrderDetailDto model);
        Task<OrderDetailDto> UpdateOrderDetail(OrderDetailDto model);
    }
}