using NSLPWasm.Dto;

namespace NSLPWasm.Services.VendorService
{
    public interface IVendorService
    {
        Task<VendorDto> AddVendor(VendorDto model);
        Task<List<VendorDto>> GetAllVendor();
        Task<VendorDto> RemoveVendor(VendorDto model);
        Task<VendorDto> UpdateVendor(VendorDto model);
    }
}