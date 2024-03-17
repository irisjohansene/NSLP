using NSLPWasm.MVVM;

namespace NSLPWasm.Services.UtilityService
{
    public interface IUtilityService
    {
        Task<PredefinedTableDto> GetAllPredefinedTable();
    }
}