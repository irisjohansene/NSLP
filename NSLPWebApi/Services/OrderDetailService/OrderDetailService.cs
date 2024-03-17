using NSLPWebApi.Data;
using NSLPWebApi.Models;
using NSLPWebApi.Repositories;

namespace NSLPWebApi.Services.OrderDetailService
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly OrderDetailRepository _repo;
        private readonly AppDbContext _db;
        public OrderDetailService(OrderDetailRepository repo, AppDbContext db)
        {
            _db = db;
            _repo = repo;
        }

        public async Task<List<OrderDetail>> GetAllOrderDetailAsync()
        {
            var ods = await _repo.GetAllAsListAsync();
            return ods;
        }

        public async Task AddOrderDetailAsync(OrderDetail od)
        {
            await _repo.AddAsync(od);
            await _repo.CompleteAsync();
            await _db.SaveChangesAsync();
        }

        public async Task UpdateOrderDetailAsync(OrderDetail od)
        {
            _db.OrderDetails.Update(od);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveOrderDetailAsync(OrderDetail od)
        {
            _db.OrderDetails.Remove(od);
            await _db.SaveChangesAsync();
        }
    }
}
