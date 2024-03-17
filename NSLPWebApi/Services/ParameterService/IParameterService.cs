using NSLPWebApi.Models;

namespace NSLPWebApi.Services.ParameterService
{
    public interface IParameterService
    {
        Task<Parameter> GetParameterByTypeAsync(string type);

        Task UpdateParameterValueAsync(Parameter param);
    }
}