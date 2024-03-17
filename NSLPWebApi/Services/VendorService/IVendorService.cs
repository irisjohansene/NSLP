using NSLPWebApi.Models;

namespace NSLPWebApi.Services.VendorService
{
    public interface IVendorService
    {
        Task AddVendorAsync(Vendor vendor);
        Task<List<Vendor>> GetAllVendorAsync();
        Task RemoveVendorAsync(Vendor vendor);
        Task UpdateVendorAsync(Vendor vendor);
    }
}