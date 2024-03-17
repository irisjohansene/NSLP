using NSLPWebApi.Data;
using NSLPWebApi.Models;

namespace NSLPWebApi.Repositories
{
    public class DocumentRepository : Repository<Document>
    {
        private readonly AppDbContext _db;

        public DocumentRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
