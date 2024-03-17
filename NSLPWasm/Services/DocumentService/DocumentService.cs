using NSLPWasm.Dto;
using NSLPWasm.DTO;
using NSLPWasm.Services.APIService;

namespace NSLPWasm.Services.DocumentService
{
    public class DocumentService : IDocumentService
    {
        private readonly IAPIService _apiService;

        APIResponseModel<List<DocumentDto>> respList = new APIResponseModel<List<DocumentDto>>();
        APIResponseModel<DocumentDto> resp = new APIResponseModel<DocumentDto>();

        public DocumentService(IAPIService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<DocumentDto>> GetAllDocument()
        {
            respList = await _apiService.InvokeGetAsync<APIResponseModel<List<DocumentDto>>>($"/api/Document/GetAllDocument");
            return respList.Data;
        }

        public async Task<DocumentDto> AddDocument(DocumentDto model)
        {
            resp.Data = await _apiService.InvokePost("/api/Document/AddDocument", model);
            return resp.Data;
        }

        public async Task<DocumentDto> UpdateDocument(DocumentDto model)
        {
            resp.Data = await _apiService.InvokePost("api/Document/UpdateDocument", model);
            return resp.Data;
        }

        public async Task<DocumentDto> RemoveDocument(DocumentDto model)
        {
            resp.Data = await _apiService.InvokePost("api/Document/RemoveDocument", model);
            return resp.Data;
        }
    }
}
