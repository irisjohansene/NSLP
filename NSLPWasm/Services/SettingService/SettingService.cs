using NSLPWasm.Dto;
using NSLPWasm.DTO;
using NSLPWasm.Services.APIService;

namespace NSLPWasm.Services.SettingService
{
    public class SettingService : ISettingService
    {
        private readonly IAPIService _apiService;

        APIResponseModel<List<SettingDto>> respList = new APIResponseModel<List<SettingDto>>();
        APIResponseModel<SettingDto> resp = new APIResponseModel<SettingDto>();

        public SettingService(IAPIService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<SettingDto>> GetAllSetting()
        {
            respList = await _apiService.InvokeGetAsync<APIResponseModel<List<SettingDto>>>($"/api/Setting/GetAllSetting");
            return respList.Data;
        }

        public async Task<SettingDto> AddSetting(SettingDto model)
        {
            resp.Data = await _apiService.InvokePost("/api/Setting/AddSetting", model);
            return resp.Data;
        }

        public async Task<SettingDto> UpdateSetting(SettingDto model)
        {
            resp.Data = await _apiService.InvokePost("api/Setting/UpdateSetting", model);
            return resp.Data;
        }

        public async Task<SettingDto> RemoveSetting(SettingDto model)
        {
            resp.Data = await _apiService.InvokePost("api/Setting/RemoveSetting", model);
            return resp.Data;
        }
    }
}
