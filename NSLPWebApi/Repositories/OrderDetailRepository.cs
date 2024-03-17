using NSLPWebApi.Data;
using NSLPWebApi.Models;

namespace NSLPWebApi.Repositories
{
    public class OrderDetailRepository : Repository<OrderDetail>
    {
        private readonly AppDbContext _db;

        public OrderDetailRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
