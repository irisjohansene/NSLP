using NSLPWebApi.Dto;
using NSLPWebApi.Models;

namespace NSLPWebApi.Services.MenuService
{
    public interface IMenuService
    {
        Task<Menu> AddMenuAsync(Menu menuDto);
        Task<List<Menu>> GetAllMenuAsync();
        Task<Menu> GetMenuByMenuIdAsync(int menuId);
        Task RemoveMenuAsync(Menu menu);
        Task UpdateMenuAsync(Menu menu);
    }
}