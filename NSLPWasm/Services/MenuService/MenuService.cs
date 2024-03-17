using NSLPWasm.Dto;
using NSLPWasm.DTO;
using NSLPWasm.Services.APIService;
using System.Diagnostics;

namespace NSLPWasm.Services.MenuService
{
    public class MenuService : IMenuService
    {
        private readonly IAPIService _apiService;

        APIResponseModel<List<MenuDto>> respList = new APIResponseModel<List<MenuDto>>();
        APIResponseModel<MenuDto> resp = new APIResponseModel<MenuDto>();

        public MenuService(IAPIService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<MenuDto>> GetAllMenu()
        {
            respList = await _apiService.InvokeGetAsync<APIResponseModel<List<MenuDto>>>($"/api/Menu/GetAllMenu");
            return respList.Data;
        }

        public async Task<MenuDto> GetMenuByMenuId(int menuId)
        {
            resp = await _apiService.InvokeGetAsync<APIResponseModel<MenuDto>>($"api/Menu/GetMenuByMenuId/{menuId}");
            return resp.Data;
        }

        public async Task<MenuDto> AddMenu(MenuDto model)
        {
            try
            {
                APIResponseModel<MenuDto> respDto = new APIResponseModel<MenuDto>();
                respDto.Data = await _apiService.InvokePostAsync("/api/Menu/AddMenu", model);
                if (respDto.Data != null)
                {
                    return respDto.Data;
                }
                
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                Debug.WriteLine(err);
            }
            return null;
        }

        public async Task<MenuDto> UpdateMenu(MenuDto model)
        {
            resp.Data = await _apiService.InvokePost("api/Menu/UpdateMenu", model);
            return resp.Data;
        }

        public async Task<MenuDto> RemoveMenu(MenuDto model)
        {
            resp.Data = await _apiService.InvokePost("api/Menu/RemoveMenu", model);
            return resp.Data;
        }
    }
}
