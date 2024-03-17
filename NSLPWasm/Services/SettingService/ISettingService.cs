using NSLPWasm.Dto;

namespace NSLPWasm.Services.SettingService
{
    public interface ISettingService
    {
        Task<SettingDto> AddSetting(SettingDto model);
        Task<List<SettingDto>> GetAllSetting();
        Task<SettingDto> RemoveSetting(SettingDto model);
        Task<SettingDto> UpdateSetting(SettingDto model);
    }
}