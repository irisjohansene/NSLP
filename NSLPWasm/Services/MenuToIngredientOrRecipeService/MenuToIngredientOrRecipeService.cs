using NSLPWasm.Dto;
using NSLPWasm.DTO;
using NSLPWasm.Services.APIService;
using System;
using System.Diagnostics;

namespace NSLPWasm.Services.MenuToIngredientService
{
    public class MenuToIngredientOrRecipeService : IMenuToIngredientOrRecipeService
    {
        private readonly IAPIService _apiService;

        APIResponseModel<List<MenuToIngredientOrRecipeDto>> respList = new APIResponseModel<List<MenuToIngredientOrRecipeDto>>();
        APIResponseModel<MenuToIngredientOrRecipeDto> resp = new APIResponseModel<MenuToIngredientOrRecipeDto>();

        public MenuToIngredientOrRecipeService(IAPIService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<MenuToIngredientOrRecipeDto>> GetAllMenuToIngredientOrRecipe()
        {
            try
            {

                respList = await _apiService.InvokeGetAsync<APIResponseModel<List<MenuToIngredientOrRecipeDto>>>($"/api/MenuToIngredientOrRecipe/GetAllMenuToIngredientOrRecipe");
                return respList.Data;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                Debug.WriteLine(err);
            }
            return null;
        }

        public async Task<IEnumerable<MenuToIngredientOrRecipeDto>> AddMenuToIngredientOrRecipe(IEnumerable<MenuToIngredientOrRecipeDto> model)
        {
            try
            {
                APIResponseModel<IEnumerable<MenuToIngredientOrRecipeDto>> res = new APIResponseModel<IEnumerable<MenuToIngredientOrRecipeDto>>();
                res.Data = await _apiService.InvokePost("/api/MenuToIngredientOrRecipe/AddMenuToIngredientOrRecipe", model);
                return res.Data;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                Debug.WriteLine(err);
            }
            return null;
        }

        public async Task<MenuToIngredientOrRecipeDto> AddOneMenuToIngredientOrRecipe(MenuToIngredientOrRecipeDto model)
        {
            try
            {
                APIResponseModel<MenuToIngredientOrRecipeDto> res = new APIResponseModel<MenuToIngredientOrRecipeDto>();
                res.Data = await _apiService.InvokePost("/api/MenuToIngredientOrRecipe/AddOneMenuToIngredientOrRecipe", model);
                return res.Data;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                Debug.WriteLine(err);
            }
            return null;
        }

        public async Task<MenuToIngredientOrRecipeDto> UpdateMenuToIngredientOrRecipe(MenuToIngredientOrRecipeDto model)
        {
            try
            {
                resp.Data = await _apiService.InvokePost("api/MenuToIngredientOrRecipe/UpdateMenuToIngredientOrRecipe", model);
                return resp.Data;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                Debug.WriteLine(err);
            }
            return null;
        }

        public async Task<MenuToIngredientOrRecipeDto> RemoveMenuToIngredientOrRecipe(MenuToIngredientOrRecipeDto model)
        {
            try
            {
                resp.Data = await _apiService.InvokePost("api/MenuToIngredientOrRecipe/RemoveMenuToIngredientOrRecipe", model);
                return resp.Data;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                Debug.WriteLine(err);
            }
            return null;
        }

        public async Task<List<MenuToIngredientOrRecipeDto>> GetAllDataByDateAndId(DateTime dateTime, int menutypeid)
        {
            try
            {
                respList = await _apiService.InvokeGetAsync<APIResponseModel<List<MenuToIngredientOrRecipeDto>>>($"/api/MenuToIngredientOrRecipe/GetAllDataByDateAndId/{dateTime}/{menutypeid}");
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
