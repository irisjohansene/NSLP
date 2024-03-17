using NSLPWebApi.Data;
using NSLPWebApi.Models;
using NSLPWebApi.Repositories;

namespace NSLPWebApi.Services.MeasurementService
{
    public class MeasurementService : IMeasurementService
    {
        private readonly MeasurementRepository _repo;
        private readonly AppDbContext _db;
        public MeasurementService(MeasurementRepository repo, AppDbContext db)
        {
            _db = db;
            _repo = repo;
        }

        public async Task<List<Measurement>> GetAllMeasurementAsync()
        {
            var measurements = await _repo.GetAllAsListAsync();
            return measurements;
        }

        public async Task AddMeasurementAsync(Measurement measurement)
        {
            await _repo.AddAsync(measurement);
            await _repo.CompleteAsync();
            await _db.SaveChangesAsync();
        }

        public async Task UpdateMeasurementAsync(Measurement measurement)
        {
            _db.Measurements.Update(measurement);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveMeasurementAsync(Measurement measurement)
        {
            _db.Measurements.Remove(measurement);
            await _db.SaveChangesAsync();
        }
    }
}
