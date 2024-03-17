using NSLPWebApi.Data;
using NSLPWebApi.Models;
using NSLPWebApi.Repositories;

namespace NSLPWebApi.Services.SettingService
{
    public class SettingService : ISettingService
    {
        private readonly SettingRepository _repo;
        private readonly AppDbContext _db;
        public SettingService(SettingRepository repo, AppDbContext db)
        {
            _db = db;
            _repo = repo;
        }

        public async Task<List<Setting>> GetAllSettingAsync()
        {
            var settings = await _repo.GetAllAsListAsync();
            return settings;
        }

        public async Task AddSettingAsync(Setting setting)
        {
            await _repo.AddAsync(setting);
            await _repo.CompleteAsync();
            await _db.SaveChangesAsync();
        }

        public async Task UpdateSettingAsync(Setting setting)
        {
            _db.Settings.Update(setting);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveSettingAsync(Setting setting)
        {
            _db.Settings.Remove(setting);
            await _db.SaveChangesAsync();
        }
    }
}
