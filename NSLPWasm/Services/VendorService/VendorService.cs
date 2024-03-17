using NSLPWasm.Dto;
using NSLPWasm.DTO;
using NSLPWasm.Services.APIService;

namespace NSLPWasm.Services.VendorService
{
    public class VendorService : IVendorService
    {
        private readonly IAPIService _apiService;

        APIResponseModel<List<VendorDto>> respList = new APIResponseModel<List<VendorDto>>();
        APIResponseModel<VendorDto> resp = new APIResponseModel<VendorDto>();

        public VendorService(IAPIService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<VendorDto>> GetAllVendor()
        {
            respList = await _apiService.InvokeGetAsync<APIResponseModel<List<VendorDto>>>($"/api/Vendor/GetAllVendor");
            return respList.Data;
        }

        public async Task<VendorDto> AddVendor(VendorDto model)
        {
            resp.Data = await _apiService.InvokePost("/api/Vendor/AddVendor", model);
            return resp.Data;
        }

        public async Task<VendorDto> UpdateVendor(VendorDto model)
        {
            resp.Data = await _apiService.InvokePost("api/Vendor/UpdateVendor", model);
            return resp.Data;
        }

        public async Task<VendorDto> RemoveVendor(VendorDto model)
        {
            resp.Data = await _apiService.InvokePost("api/Vendor/RemoveVendor", model);
            return resp.Data;
        }
    }
}
