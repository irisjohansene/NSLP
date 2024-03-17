using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace NSLPWasm.Services.APIService
{
    public class APIService : IAPIService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseURL;


        public APIService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }

        public async Task<T> InvokeGetAsync<T>(string uri)
        {
            return await _httpClient.GetFromJsonAsync<T>(uri);
        }

        public async Task<byte[]> InvokeGetPDF(string uri)
        {
            return await _httpClient.GetByteArrayAsync(uri);
        }

        public async Task<T> InvokePost<T>(string uri, T obj)
        {
            var response = await _httpClient.PostAsJsonAsync(uri, obj);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<T>();
        }

        //public async Task<List<string>> InvokeStringPost<T>(string uri, T obj)
        //{

        //    var response = await _httpClient.PostAsJsonAsync(uri, obj);
        //    //APIResponse<List<string>> opdData = await response.Content.ReadFromJsonAsync<APIResponse<List<string>>>();
        //    response.EnsureSuccessStatusCode();

        //    //var opdCode = opdData.Data.patientDto.Opd_Code;

        //    // Read the response content as a string
        //    return await response.Content.ReadAsStringAsync();
        //}


        public async Task<T> InvokePostAsync<T>(string uri, T obj)
        {
            var response = await _httpClient.PostAsJsonAsync(uri, obj);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<T>();
        }

        public async Task<T> InvokePostAsync<T, U>(string uri, U obj)
        {
            var response = await _httpClient.PostAsJsonAsync(uri, obj);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<T>();
        }

        public async Task<T> InvokeRetPostAsync<T, U>(string uri, U obj)
        {
            var response = await _httpClient.PostAsJsonAsync(uri, obj);
            return await response.Content.ReadFromJsonAsync<T>();
        }

        //public async Task<HttpResponseMessage> InvokePostWithDataAsync<T>(string uri, T obj)
        //{
        //    var response = await _httpClient.PostAsJsonAsync(uri, obj);
        //    response.EnsureSuccessStatusCode();
        //    return response;

        //    //var ret = await respMsg.Content.ReadFromJsonAsync<APIResponseContainer<IEnumerable<designtemplates>>>();

        //    //return ret;

        //}

        //public async Task<APIResponse<OutPatientDetailsDto>> InvokePostWithDataAsync<T>(string uri, T obj)
        //{
        //    //var response = await _http.PostAsJsonAsync("api/CustomerDailyTransaction/DailyTans", custParam);
        //    //ServiceResponseViewModel<List<GeneralTransactionsViewModel>> returnVal = await response.Content.ReadFromJsonAsync<ServiceResponseViewModel<List<GeneralTransactionsViewModel>>>();


        //    var response = await _httpClient.PostAsJsonAsync(uri, obj);
        //    APIResponse<OutPatientDetailsDto> opdData = await response.Content.ReadFromJsonAsync<APIResponse<OutPatientDetailsDto>>();
        //    response.EnsureSuccessStatusCode();

        //    //var opdCode = opdData.Data.patientDto.Opd_Code;

        //    // Read the response content as a string
        //    //string responseBody = await response.Content.ReadAsStringAsync();

        //    return opdData;
        //}



        public async Task<T> InvokePut<T>(string uri, T obj)
        {
            var response = await _httpClient.PutAsJsonAsync(uri, obj);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<T>();
        }

        public async Task InvokeDelete<T>(string uri)
        {
            var response = await _httpClient.DeleteAsync(uri);
            response.EnsureSuccessStatusCode();
        }

        private string GetURL(string uri)
        {
            return $"{_baseURL}/{uri}";
        }
    }
}