using Microsoft.EntityFrameworkCore;
using NSLPWebApi.Data;
using NSLPWebApi.Models;
using NSLPWebApi.Repositories;

namespace NSLPWebApi.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly OrderRepository _repo;
        private readonly AppDbContext _db;
        public OrderService(OrderRepository repo, AppDbContext db)
        {
            _db = db;
            _repo = repo;
        }

        public async Task<List<Order>> GetAllOrderAsync()
        {
            var orders = await _repo.GetAllAsListAsync();
            return orders;
        }

        public async Task<Order> GetOrderByOrderIdAsync(int orderId)
        {
            var order = await _repo.GetAsync(x => x.OrderId == orderId);
            await _db.OrderDetails.Where(x => x.OrderId == order.OrderId).LoadAsync();
            return order;
        }

        public async Task AddOrderAsync(Order order)
        {
            await _repo.AddAsync(order);
            await _repo.CompleteAsync();
            await _db.SaveChangesAsync();
        }

        public async Task UpdateOrderAsync(Order order)
        {
            _db.Orders.Update(order);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveOrderAsync(Order order)
        {
            _db.Orders.Remove(order);
            await _db.SaveChangesAsync();
        }
    }
}
