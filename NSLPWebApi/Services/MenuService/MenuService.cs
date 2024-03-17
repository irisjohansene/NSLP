using Microsoft.EntityFrameworkCore;
using NSLPWebApi.Data;
using NSLPWebApi.Dto;
using NSLPWebApi.Models;
using NSLPWebApi.Repositories;

namespace NSLPWebApi.Services.MenuService
{
    public class MenuService : IMenuService
    {
        private readonly MenuRepository _repo;
        private readonly AppDbContext _db;
        public MenuService(MenuRepository repo, AppDbContext db)
        {
            _db = db;
            _repo = repo;
        }

        public async Task<List<Menu>> GetAllMenuAsync()
        {
            var menus = await _repo.GetAllAsListAsync();
            return menus;
        }

        public async Task<Menu> GetMenuByMenuIdAsync(int menuId)
        {
            var menu = await _repo.GetAsync(x => x.MenuId == menuId);
            await _db.MenuToIngredientOrRecipes.Where(x=>x.MenuId == menu.MenuId).LoadAsync();
            return menu;
        }

        public async Task<Menu> AddMenuAsync(Menu menu)
        {
            try
            {
                await _repo.AddAsync(menu);
                await _repo.CompleteAsync();
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                //return StatusCode(500, $"Internal server error: {ex.Message}");
            }
            return null;
        }

        public async Task UpdateMenuAsync(Menu menu)
        {
            _db.Menus.Update(menu);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveMenuAsync(Menu menu)
        {
            _db.Menus.Remove(menu);
            await _db.SaveChangesAsync();
        }
    }
}
