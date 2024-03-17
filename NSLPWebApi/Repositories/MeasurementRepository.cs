using NSLPWebApi.Data;
using NSLPWebApi.Models;

namespace NSLPWebApi.Repositories
{
    public class MeasurementRepository : Repository<Measurement>
    {
        private readonly AppDbContext _db;

        public MeasurementRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
