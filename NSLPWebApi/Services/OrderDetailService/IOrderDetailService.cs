using NSLPWebApi.Models;

namespace NSLPWebApi.Services.OrderDetailService
{
    public interface IOrderDetailService
    {
        Task AddOrderDetailAsync(OrderDetail od);
        Task<List<OrderDetail>> GetAllOrderDetailAsync();
        Task RemoveOrderDetailAsync(OrderDetail od);
        Task UpdateOrderDetailAsync(OrderDetail od);
    }
}