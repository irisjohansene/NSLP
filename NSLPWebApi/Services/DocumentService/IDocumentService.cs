using NSLPWebApi.Models;

namespace NSLPWebApi.Services.DocumentService
{
    public interface IDocumentService
    {
        Task AddDocumentAsync(Document document);
        Task<List<Document>> GetAllDocumentAsync();
        Task RemoveDocumentAsync(Document document);
        Task UpdateDocumentAsync(Document document);
    }
}