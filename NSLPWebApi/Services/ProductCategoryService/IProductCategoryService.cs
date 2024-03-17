using NSLPWebApi.Models;

namespace NSLPWebApi.Services.ProductCategoryService
{
    public interface IProductCategoryService
    {
        Task AddProductCategoryAsync(ProductCategory pc);
        Task<List<ProductCategory>> GetAllProductCategoryAsync();
        Task RemoveProductCategoryAsync(ProductCategory pc);
        Task UpdateProductCategoryAsync(ProductCategory pc);
    }
}