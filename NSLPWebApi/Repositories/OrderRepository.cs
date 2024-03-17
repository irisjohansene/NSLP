using NSLPWebApi.Data;
using NSLPWebApi.Models;

namespace NSLPWebApi.Repositories
{
    public class OrderRepository : Repository<Order>
    {
        private readonly AppDbContext _db;

        public OrderRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
