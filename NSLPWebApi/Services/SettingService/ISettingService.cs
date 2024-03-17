using NSLPWebApi.Models;

namespace NSLPWebApi.Services.SettingService
{
    public interface ISettingService
    {
        Task AddSettingAsync(Setting setting);
        Task<List<Setting>> GetAllSettingAsync();
        Task RemoveSettingAsync(Setting setting);
        Task UpdateSettingAsync(Setting setting);
    }
}