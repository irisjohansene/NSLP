using NSLPWasm.Dto;

namespace NSLPWasm.Services.OrderService
{
    public interface IOrderService
    {
        Task<OrderDto> AddOrder(OrderDto model);
        Task<List<OrderDto>> GetAllOrder();
        Task<OrderDto> GetOrderByOrderId(int orderId);
        Task<OrderDto> RemoveOrder(OrderDto model);
        Task<OrderDto> UpdateOrder(OrderDto model);
    }
}