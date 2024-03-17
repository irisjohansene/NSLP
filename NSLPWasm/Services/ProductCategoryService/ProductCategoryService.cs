using NSLPWasm.Dto;
using NSLPWasm.DTO;
using NSLPWasm.Services.APIService;

namespace NSLPWasm.Services.ProductCategoryService
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IAPIService _apiService;

        APIResponseModel<List<ProductCategoryDto>> respList = new APIResponseModel<List<ProductCategoryDto>>();

        public ProductCategoryService(IAPIService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<ProductCategoryDto>> GetAllProductCategory()
        {
            respList = await _apiService.InvokeGetAsync<APIResponseModel<List<ProductCategoryDto>>>($"/api/ProductCategory/GetAllProductCategory");
            return respList.Data;
        }
    }
}
