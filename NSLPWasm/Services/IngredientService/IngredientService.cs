using NSLPWasm.Services.APIService;
using NSLPWasm.Dto;
using NSLPWasm.DTO;
using System.Diagnostics;

namespace NSLPWasm.Services.IngredientService.IngredientService
{
    public class IngredientService : IIngredientService
    {
        private readonly IAPIService _apiService;

        APIResponseModel<List<IngredientDto>> respList = new APIResponseModel<List<IngredientDto>>();
        APIResponseModel<IngredientDto> resp = new APIResponseModel<IngredientDto>();

        public IngredientService(IAPIService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<IngredientDto>> GetAllIngredient()
        {
            try
            {
                respList = await _apiService.InvokeGetAsync<APIResponseModel<List<IngredientDto>>>($"/api/Ingredient/GetAllIngredient");
                return respList.Data;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                Debug.WriteLine(err);
            }
            return null;
        }

        public async Task<IngredientDto> AddIngredient(IngredientDto model)
        {
            try
            {
                resp.Data = await _apiService.InvokePost("/api/Ingredient/AddIngredient", model);
                return resp.Data;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                Debug.WriteLine(err);
            }
            return null;
        }

        public async Task<IngredientDto> UpdateIngredient(IngredientDto model)
        {
            try
            {
                resp.Data = await _apiService.InvokePost("api/Ingredient/UpdateIngredient", model);
                return resp.Data;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                Debug.WriteLine(err);
            }
            return null;
        }

        public async Task<IngredientDto> RemoveIngredient(IngredientDto model)
        {
            try
            {
                resp.Data = await _apiService.InvokePost("api/Ingredient/RemoveIngredient", model);
                return resp.Data;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                Debug.WriteLine(err);
            }
            return null;
        }
    }
}
