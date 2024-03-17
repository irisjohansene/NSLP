using NSLPWebApi.Models;

namespace NSLPWebApi.Services.MenuTypeService
{
    public interface IMenuTypeService
    {
        Task AddMenuTypeAsync(MenuType menuType);
        Task<List<MenuType>> GetAllMenuTypeAsync();
        Task RemoveMenuTypeAsync(MenuType menuType);
        Task UpdateMenuTypeAsync(MenuType menuType);
    }
}