using NSLPWasm.Dto;
using NSLPWasm.DTO;
using NSLPWasm.Services.APIService;

namespace NSLPWasm.Services.IngredientTypeService
{
    public class IngredientTypeService : IIngredientTypeService
    {
        private readonly IAPIService _apiService;

        APIResponseModel<List<IngredientTypeDto>> respList = new APIResponseModel<List<IngredientTypeDto>>();
        APIResponseModel<IngredientTypeDto> resp = new APIResponseModel<IngredientTypeDto>();

        public IngredientTypeService(IAPIService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<IngredientTypeDto>> GetAllIngredientType()
        {
            respList = await _apiService.InvokeGetAsync<APIResponseModel<List<IngredientTypeDto>>>($"/api/IngredientType/GetAllIngredientType");
            return respList.Data;
        }

        public async Task<IngredientTypeDto> AddIngredientType(IngredientTypeDto model)
        {
            resp.Data = await _apiService.InvokePost("/api/IngredientType/AddIngredientType", model);
            return resp.Data;
        }

        public async Task<IngredientTypeDto> UpdateIngredientType(IngredientTypeDto model)
        {
            resp.Data = await _apiService.InvokePost("api/IngredientType/UpdateIngredientType", model);
            return resp.Data;
        }

        public async Task<IngredientTypeDto> RemoveIngredientType(IngredientTypeDto model)
        {
            resp.Data = await _apiService.InvokePost("api/IngredientType/RemoveIngredientType", model);
            return resp.Data;
        }
    }
}
