using NSLPWasm.Dto;
using NSLPWasm.DTO;

namespace NSLPWasm.Services.MenuTypeService
{
    public interface IMenuTypeService
    {
        Task<List<MenuTypeDto>> GetAllMenuType();
    }
}