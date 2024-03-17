using NSLPWasm.Dto;
using NSLPWasm.DTO;
using NSLPWasm.Services.APIService;

namespace NSLPWasm.Services.MeasurementService
{
    public class MeasurementService : IMeasurementService
    {
        private readonly IAPIService _apiService;

        APIResponseModel<List<MeasurementDto>> respList = new APIResponseModel<List<MeasurementDto>>();

        public MeasurementService(IAPIService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<MeasurementDto>> GetAllMeasurement()
        {
            respList = await _apiService.InvokeGetAsync<APIResponseModel<List<MeasurementDto>>>($"/api/Measurement/GetAllMeasurement");
            return respList.Data;
        }
    }
}
