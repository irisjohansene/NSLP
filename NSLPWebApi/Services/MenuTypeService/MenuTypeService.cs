using NSLPWebApi.Data;
using NSLPWebApi.Models;
using NSLPWebApi.Repositories;

namespace NSLPWebApi.Services.MenuTypeService
{
    public class MenuTypeService : IMenuTypeService
    {
        private readonly MenuTypeRepository _repo;
        private readonly AppDbContext _db;
        public MenuTypeService(MenuTypeRepository repo, AppDbContext db)
        {
            _db = db;
            _repo = repo;
        }

        public async Task<List<MenuType>> GetAllMenuTypeAsync()
        {
            var menuTypes = await _repo.GetAllAsListAsync();
            return menuTypes;
        }

        public async Task AddMenuTypeAsync(MenuType menuType)
        {
            await _repo.AddAsync(menuType);
            await _repo.CompleteAsync();
            await _db.SaveChangesAsync();
        }

        public async Task UpdateMenuTypeAsync(MenuType menuType)
        {
            _db.MenuTypes.Update(menuType);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveMenuTypeAsync(MenuType menuType)
        {
            _db.MenuTypes.Remove(menuType);
            await _db.SaveChangesAsync();
        }
    }
}
