using NSLPWebApi.Data;
using NSLPWebApi.Models;
using NSLPWebApi.Repositories;

namespace NSLPWebApi.Services.VendorService
{
    public class VendorService : IVendorService
    {
        private readonly VendorRepository _repo;
        private readonly AppDbContext _db;
        public VendorService(VendorRepository repo, AppDbContext db)
        {
            _db = db;
            _repo = repo;
        }

        public async Task<List<Vendor>> GetAllVendorAsync()
        {
            var vendors = await _repo.GetAllAsListAsync();
            return vendors;
        }

        public async Task AddVendorAsync(Vendor vendor)
        {
            await _repo.AddAsync(vendor);
            await _repo.CompleteAsync();
            await _db.SaveChangesAsync();
        }

        public async Task UpdateVendorAsync(Vendor vendor)
        {
            _db.Vendors.Update(vendor);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveVendorAsync(Vendor vendor)
        {
            _db.Vendors.Remove(vendor);
            await _db.SaveChangesAsync();
        }
    }
}
