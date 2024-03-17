using NSLPWebApi.Models;

namespace NSLPWebApi.Services.OrderService
{
    public interface IOrderService
    {
        Task AddOrderAsync(Order order);
        Task<List<Order>> GetAllOrderAsync();
        Task<Order> GetOrderByOrderIdAsync(int orderId);
        Task RemoveOrderAsync(Order order);
        Task UpdateOrderAsync(Order order);
    }
}