using NSLPWasm.Dto;
using NSLPWasm.DTO;
using NSLPWasm.Services.APIService;
using System.Diagnostics;

namespace NSLPWasm.Services.RecipeToIngredientService
{
    public class RecipeToIngredientService : IRecipeToIngredientService
    {
        private readonly IAPIService _apiService;

        APIResponseModel<List<RecipeToIngredientDto>> respList = new APIResponseModel<List<RecipeToIngredientDto>>();
        APIResponseModel<RecipeToIngredientDto> resp = new APIResponseModel<RecipeToIngredientDto>();

        public RecipeToIngredientService(IAPIService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<RecipeToIngredientDto>> GetAllRecipeToIngredient()
        {
            try
            {
                respList = await _apiService.InvokeGetAsync<APIResponseModel<List<RecipeToIngredientDto>>>($"/api/RecipeToIngredient/GetAllRecipeToIngredient");
                return respList.Data;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                Debug.WriteLine(err);
            }
            return null;
        }

        public async Task<RecipeToIngredientDto> AddRecipeToIngredient(RecipeToIngredientDto model)
        {
            try
            {
                resp.Data = await _apiService.InvokePost("/api/RecipeToIngredient/AddRecipeToIngredient", model);
                return resp.Data;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                Debug.WriteLine(err);
            }
            return null;
        }

        public async Task<RecipeToIngredientDto> UpdateRecipeToIngredient(RecipeToIngredientDto model)
        {
            try
            {
                resp.Data = await _apiService.InvokePost("api/RecipeToIngredient/UpdateRecipeToIngredient", model);
                return resp.Data;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                Debug.WriteLine(err);
            }
            return null;
        }

        public async Task<RecipeToIngredientDto> RemoveRecipeToIngredient(RecipeToIngredientDto model)
        {
            try
            {
                resp.Data = await _apiService.InvokePost("api/RecipeToIngredient/RemoveRecipeToIngredient", model);
                return resp.Data;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                Debug.WriteLine(err);
            }
            return null;
        }

        public async Task<List<RecipeToIngredientDto>> GetAllRecipeToIngredientByRecipeId(int recipeId)
        {
            try
            {
                respList = await _apiService.InvokeGetAsync<APIResponseModel<List<RecipeToIngredientDto>>>($"/api/RecipeToIngredient/GetAllRecipeToIngredientByRecipeId/{recipeId}");
                return respList.Data;
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
