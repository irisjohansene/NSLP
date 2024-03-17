using NSLPWebApi.Models;

namespace NSLPWebApi.Services.ComponentSubTypeService
{
    public interface IComponentSubTypeService
    {
        Task AddComponentSubTypeAsync(ComponentSubType subtype);
        Task<List<ComponentSubType>> GetAllComponentSubTypeAsync();
        Task<List<ComponentSubType>> GetAllComponentSubTypeByTypeAsync(int type);
        Task RemoveComponentSubTypeAsync(ComponentSubType subtype);
        Task UpdateComponentSubTypeAsync(ComponentSubType subtype);
    }
}