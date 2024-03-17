using NSLPWasm.DTO;
using NSLPWasm.MVVM;
using NSLPWasm.Services.APIService;

namespace NSLPWasm.Services.UtilityService
{
    public class UtilityService : IUtilityService
    {
        private readonly IAPIService _apiService;

        APIResponseModel<PredefinedTableDto> respList = new APIResponseModel<PredefinedTableDto>();

        public UtilityService(IAPIService apiService)
        {
            _apiService = apiService;
        }

        public async Task<PredefinedTableDto> GetAllPredefinedTable()
        {
            respList = await _apiService.InvokeGetAsync<APIResponseModel<PredefinedTableDto>>($"/api/Utility/GetAllPredefinedTable");
            return respList.Data;
        }
    }
}
