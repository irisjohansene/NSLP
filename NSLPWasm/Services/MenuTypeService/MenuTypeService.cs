using NSLPWasm.Dto;
using NSLPWasm.DTO;
using NSLPWasm.Services.APIService;

namespace NSLPWasm.Services.MenuTypeService
{
    public class MenuTypeService : IMenuTypeService
    {
        private readonly IAPIService _apiService;

        APIResponseModel<List<MenuTypeDto>> respList = new APIResponseModel<List<MenuTypeDto>>();

        public MenuTypeService(IAPIService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<MenuTypeDto>> GetAllMenuType()
        {
            respList = await _apiService.InvokeGetAsync<APIResponseModel<List<MenuTypeDto>>>($"/api/MenuType/GetAllMenuType");
            return respList.Data;
        }
    }
}
