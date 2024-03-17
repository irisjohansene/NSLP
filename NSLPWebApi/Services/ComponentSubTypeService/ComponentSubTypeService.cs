using NSLPWebApi.Data;
using NSLPWebApi.Models;
using NSLPWebApi.Repositories;

namespace NSLPWebApi.Services.ComponentSubTypeService
{
    public class ComponentSubTypeService : IComponentSubTypeService
    {
        private readonly ComponentSubTypesRepository _repo;
        private readonly AppDbContext _db;
        public ComponentSubTypeService(ComponentSubTypesRepository repo, AppDbContext db)
        {
            _db = db;
            _repo = repo;
        }

        public async Task<List<ComponentSubType>> GetAllComponentSubTypeAsync()
        {
            var subtypes = await _repo.GetAllAsListAsync();
            return subtypes;
        }

        public async Task<List<ComponentSubType>> GetAllComponentSubTypeByTypeAsync(int type)
        {
            var subTypes = await _repo.GetAllAsListAsync();
            var filteredSubTypes = subTypes.Where(subType => subType.ComponentTypeId == type).ToList();
            return filteredSubTypes;
        }



        public async Task AddComponentSubTypeAsync(ComponentSubType subtype)
        {
            await _repo.AddAsync(subtype);
            await _repo.CompleteAsync();
            await _db.SaveChangesAsync();
        }

        public async Task UpdateComponentSubTypeAsync(ComponentSubType subtype)
        {
            _db.ComponentSubTypes.Update(subtype);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveComponentSubTypeAsync(ComponentSubType subtype)
        {
            _db.ComponentSubTypes.Remove(subtype);
            await _db.SaveChangesAsync();
        }
    }
}
