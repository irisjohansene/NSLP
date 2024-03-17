using NSLPWebApi.Dto;

namespace NSLPWebApi.Services.UtilityService
{
    public interface IUtilityService
    {
        Task<PredefinedTableDto> GetAllPredefinedTable();
    }
}