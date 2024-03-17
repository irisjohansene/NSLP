using NSLPWasm.Dto;
using NSLPWasm.DTO;
using NSLPWasm.Services.APIService;
using System.Diagnostics;

namespace NSLPWasm.Services.RecipeService
{
    public class RecipeService : IRecipeService
    {
        private readonly IAPIService _apiService;

        APIResponseModel<List<RecipeDto>> respList = new APIResponseModel<List<RecipeDto>>();
        APIResponseModel<RecipeDto> resp = new APIResponseModel<RecipeDto>();

        public RecipeService(IAPIService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<RecipeDto>> GetAllRecipe()
        {
            try
            {
                respList = await _apiService.InvokeGetAsync<APIResponseModel<List<RecipeDto>>>($"/api/Recipe/GetAllRecipe");
                return respList.Data;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                Debug.WriteLine(err);
            }
            return null;
        }

        public async Task<RecipeDto> GetRecipeByRecipeId(int recipeId)
        {
            try
            {
                resp = await _apiService.InvokeGetAsync<APIResponseModel<RecipeDto>>($"api/Recipe/GetRecipeByRecipeId/{recipeId}");
                return resp.Data;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                Debug.WriteLine(err);
            }
            return null;
        }

        public async Task<int?> AddRecipe(RecipeDto model)
        {
            try
            {
                resp.Data = await _apiService.InvokePost("/api/Recipe/AddRecipe", model);
                return resp.Data.RecipeId;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                Debug.WriteLine(err);
            }
            return null;
        }

        public async Task<RecipeDto> UpdateRecipe(RecipeDto model)
        {
            try
            {
                resp.Data = await _apiService.InvokePost("api/Recipe/UpdateRecipe", model);
                return resp.Data;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                Debug.WriteLine(err);
            }
            return null;
        }

        public async Task<RecipeDto> RemoveRecipe(RecipeDto model)
        {
            try
            {
                resp.Data = await _apiService.InvokePost("api/Recipe/RemoveRecipe", model);
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
