using NSLPWasm.Dto;

namespace NSLPWasm.Services.MeasurementService
{
    public interface IMeasurementService
    {
        Task<List<MeasurementDto>> GetAllMeasurement();
    }
}