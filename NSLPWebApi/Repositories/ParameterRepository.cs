using NSLPWebApi.Data;
using NSLPWebApi.Models;
using NSLPWebApi.Repositories;

namespace NSLPWebApi.Respositories
{
    public class ParameterRepository : Repository<Parameter>
    {
        private readonly AppDbContext _db;

        public ParameterRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
