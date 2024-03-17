using NSLPWebApi.Data;
using NSLPWebApi.Models;

namespace NSLPWebApi.Repositories
{
    public class VendorRepository : Repository<Vendor>
    {
        private readonly AppDbContext _db;

        public VendorRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
