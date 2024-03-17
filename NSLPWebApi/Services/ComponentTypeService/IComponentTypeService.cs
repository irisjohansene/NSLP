using NSLPWebApi.Models;

namespace NSLPWebApi.Services.ComponentTypeService
{
    public interface IComponentTypeService
    {
        Task AddComponentTypeAsync(ComponentType type);
        Task<List<ComponentType>> GetAllComponentTypeAsync();
        Task RemoveComponentTypeAsync(ComponentType type);
        Task UpdateComponentTypeAsync(ComponentType type);
    }
}