using NSLPWebApi.Data;
using NSLPWebApi.Models;
using NSLPWebApi.Repositories;

namespace NSLPWebApi.Services.ComponentTypeService
{
    public class ComponentTypeService : IComponentTypeService
    {
        private readonly ComponentTypeRepository _repo;
        private readonly AppDbContext _db;
        public ComponentTypeService(ComponentTypeRepository repo, AppDbContext db)
        {
            _db = db;
            _repo = repo;
        }

        public async Task<List<ComponentType>> GetAllComponentTypeAsync()
        {
            var types = await _repo.GetAllAsListAsync();
            return types;
        }

        public async Task AddComponentTypeAsync(ComponentType type)
        {
            await _repo.AddAsync(type);
            await _repo.CompleteAsync();
            await _db.SaveChangesAsync();
        }

        public async Task UpdateComponentTypeAsync(ComponentType type)
        {
            _db.ComponentTypes.Update(type);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveComponentTypeAsync(ComponentType type)
        {
            _db.ComponentTypes.Remove(type);
            await _db.SaveChangesAsync();
        }
    }
}
