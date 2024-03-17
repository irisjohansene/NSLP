using NSLPWebApi.Models;

namespace NSLPWebApi.Services.MeasurementService
{
    public interface IMeasurementService
    {
        Task AddMeasurementAsync(Measurement measurement);
        Task<List<Measurement>> GetAllMeasurementAsync();
        Task RemoveMeasurementAsync(Measurement measurement);
        Task UpdateMeasurementAsync(Measurement measurement);
    }
}