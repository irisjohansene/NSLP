using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;
using NSLPWebApi.Dto;
using NSLPWebApi.DTO;
using NSLPWebApi.Models;
using NSLPWebApi.Services.ParameterService;
using Serilog;

namespace NSLPWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParameterController : ControllerBase
    {
        IParameterService _parameterService;
        IMapper _mapper;

        public ParameterController(IParameterService parameterService, IMapper mapper)
        {
            _parameterService = parameterService;
            _mapper = mapper;
        }

        [HttpPost("GenerateNo")]
        public async Task<IActionResult> GenerateNo(ParameterDto param)
        {
            String no = string.Empty;
            string year = DateTime.Now.ToString("yy");
            string value = string.Empty;
            ParameterDto paramDto = new ParameterDto();
            try
            {
                var apiResponse = new APIResponseModelDto<GenerateNoResponse>();
                var par = await _parameterService.GetParameterByTypeAsync(param.ParameterType);

                value = Convert.ToString(par.ParameterValue + 1);
                if(par.ParameterType == "menuid")
                {
                    no = year + "3" + value.ToString().PadLeft(7, '0');
                }
                else
                {
                    no = "Parameter Type not found.";
                }
                paramDto.ParameterType = param.ParameterType;
                paramDto.ParameterValue = Convert.ToInt32(value);
                await UpdateNo(paramDto);

                apiResponse.Data = new GenerateNoResponse { SequenceNo = no };
                apiResponse.Error = false;
                apiResponse.Message = "Success";
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("GenerateSequenceNo")]
        public async Task<IActionResult> GenerateSequnceNo(SequenceNoDto seq)
        {
            String no = string.Empty;
            string year = DateTime.Now.ToString("yy");
            string value = string.Empty;
            ParameterDto paramDto = new ParameterDto();
            try
            {
                var apiResponse = new APIResponseModelDto<GenerateNoResponse>();
                var par = await _parameterService.GetParameterByTypeAsync(seq.ParameterType);

                value = Convert.ToString(par.ParameterValue + 1); 
                if(seq.TransactionType == "REQUEST")
                {
                    no = seq.DeptarmentCode + "RZ" + value.ToString().PadLeft(6, '0');
                }
                else
                {
                    no = seq.DeptarmentCode + "Z" + value.ToString().PadLeft(7, '0');
                }
    
                paramDto.ParameterType = seq.ParameterType;
                paramDto.ParameterValue = Convert.ToInt32(value);
                await UpdateNo(paramDto);

                apiResponse.Data = new GenerateNoResponse { SequenceNo = no };
                apiResponse.Error = false;
                apiResponse.Message = "Success";
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //[HttpPost("UpdateNo")]
        private async Task<IActionResult> UpdateNo(ParameterDto param)
        {
            var apiResponse = new APIResponseModelDto<Parameter>();
            var parModel = _mapper.Map<Parameter>(param);

            try
            {
                //parModel.ParameterValue = +1;
                await _parameterService.UpdateParameterValueAsync(parModel);
                apiResponse.Data = parModel;
                apiResponse.Error = false;
                apiResponse.Message = "Success";


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
