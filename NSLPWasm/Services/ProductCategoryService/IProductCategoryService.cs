using NSLPWasm.Dto;

namespace NSLPWasm.Services.ProductCategoryService
{
    public interface IProductCategoryService
    {
        Task<List<ProductCategoryDto>> GetAllProductCategory();
    }
}