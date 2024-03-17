using System.Threading.Tasks;

namespace NSLPWasm.Services.APIService
{
    public interface IAPIService
    {
        Task InvokeDelete<T>(string uri);
        Task<T> InvokeGetAsync<T>(string uri);
        Task<byte[]> InvokeGetPDF(string uri);
        Task<T> InvokePost<T>(string uri, T obj);
        //Task<List<string>> InvokeStringPost<T>(string uri, T obj);
        Task<T> InvokePostAsync<T>(string uri, T obj);
        Task<T> InvokePostAsync<T, U>(string uri, U obj);
        //Task<APIResponse<OutPatientDetailsDto>> InvokePostWithDataAsync<T>(string uri, T obj);
        Task<T> InvokePut<T>(string uri, T obj);
        Task<T> InvokeRetPostAsync<T, U>(string uri, U obj);
    }
}