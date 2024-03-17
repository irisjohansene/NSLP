using NSLPWasm.Dto;
using NSLPWasm.DTO;

namespace NSLPWasm.Services.MenuService
{
    public interface IMenuService
    {
        Task<MenuDto> AddMenu(MenuDto model);
        Task<List<MenuDto>> GetAllMenu();
        Task<MenuDto> GetMenuByMenuId(int menuId);
        Task<MenuDto> RemoveMenu(MenuDto model);
        Task<MenuDto> UpdateMenu(MenuDto model);
    }
}