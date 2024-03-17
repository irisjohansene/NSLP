using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSLPWebApi.Dto;
using NSLPWebApi.DTO;
using NSLPWebApi.Models;
using NSLPWebApi.Services.VendorService;

namespace NSLPWebApi.Controllers
{
    [EnableCors("AllowedOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IVendorService _vendorService;
        private readonly IMapper _mapper;

        public VendorController(IVendorService vendorService, IMapper mapper)
        {
            _vendorService = vendorService;
            _mapper = mapper;
        }

        [HttpGet("GetAllVendor")]
        public async Task<IActionResult> GetAllVendor()
        {
            try
            {
                var apiResponse = new APIResponseModelDto<List<Vendor>>();
                var ing = await _vendorService.GetAllVendorAsync();

                apiResponse.Data = ing;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddVendor")]
        public async Task<IActionResult> AddVendor(VendorDto model)
        {
            var apiResponse = new APIResponseModelDto<Vendor>();
            var ingModel = _mapper.Map<Vendor>(model);

            try
            {
                await _vendorService.AddVendorAsync(ingModel);

                apiResponse.Data = ingModel;
                apiResponse.Error = false;

                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                apiResponse.Message = ex.Message;
                apiResponse.Error = true;
                return BadRequest(apiResponse);
            }
        }

        [HttpPost("UpdateVendor")]
        public async Task<IActionResult> UpdateVendor(VendorDto model)
        {
            var apiResponse = new APIResponseModelDto<Vendor>();
            var ingModel = _mapper.Map<Vendor>(model);

            try
            {
                await _vendorService.UpdateVendorAsync(ingModel);

                apiResponse.Data = ingModel;
                apiResponse.Error = false;

                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                apiResponse.Message = ex.Message;
                apiResponse.Error = true;
                return BadRequest(apiResponse);
            }
        }

        [HttpPost("RemoveVendor")]
        public async Task<IActionResult> RemoveVendor(VendorDto model)
        {
            var apiResponse = new APIResponseModelDto<Vendor>();
            var ingModel = _mapper.Map<Vendor>(model);

            try
            {
                await _vendorService.RemoveVendorAsync(ingModel);

                apiResponse.Data = ingModel;
                apiResponse.Error = false;

                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                apiResponse.Message = ex.Message;
                apiResponse.Error = true;
                return BadRequest(apiResponse);
            }
        }
    }
}
