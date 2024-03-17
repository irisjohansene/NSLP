using NSLPWasm.Dto;

namespace NSLPWasm.Services.DocumentService
{
    public interface IDocumentService
    {
        Task<DocumentDto> AddDocument(DocumentDto model);
        Task<List<DocumentDto>> GetAllDocument();
        Task<DocumentDto> RemoveDocument(DocumentDto model);
        Task<DocumentDto> UpdateDocument(DocumentDto model);
    }
}