using NSLPWebApi.Data;
using NSLPWebApi.Models;
using NSLPWebApi.Repositories;

namespace NSLPWebApi.Services.DocumentService
{
    public class DocumentService : IDocumentService
    {
        private readonly DocumentRepository _repo;
        private readonly AppDbContext _db;
        public DocumentService(DocumentRepository repo, AppDbContext db)
        {
            _db = db;
            _repo = repo;
        }

        public async Task<List<Document>> GetAllDocumentAsync()
        {
            var documents = await _repo.GetAllAsListAsync();
            return documents;
        }

        public async Task AddDocumentAsync(Document document)
        {
            await _repo.AddAsync(document);
            await _repo.CompleteAsync();
            await _db.SaveChangesAsync();
        }

        public async Task UpdateDocumentAsync(Document document)
        {
            _db.Documents.Update(document);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveDocumentAsync(Document document)
        {
            _db.Documents.Remove(document);
            await _db.SaveChangesAsync();
        }
    }
}
