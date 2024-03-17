using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSLPWebApi.Dto;
using NSLPWebApi.DTO;
using NSLPWebApi.Models;
using NSLPWebApi.Services.MeasurementService;

namespace NSLPWebApi.Controllers
{
    [EnableCors("AllowedOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementController : ControllerBase
    {
        private readonly IMeasurementService _measurementService;
        private readonly IMapper _mapper;

        public MeasurementController(IMeasurementService measurementService, IMapper mapper)
        {
            _measurementService = measurementService;
            _mapper = mapper;
        }

        [HttpGet("GetAllMeasurement")]
        public async Task<IActionResult> GetAllMeasurement()
        {
            try
            {
                var apiResponse = new APIResponseModelDto<List<Measurement>>();
                var ing = await _measurementService.GetAllMeasurementAsync();

                apiResponse.Data = ing;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddMeasurement")]
        public async Task<IActionResult> AddMeasurement(MeasurementDto model)
        {
            var apiResponse = new APIResponseModelDto<Measurement>();
            var ingModel = _mapper.Map<Measurement>(model);

            try
            {
                await _measurementService.AddMeasurementAsync(ingModel);

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

        [HttpPost("UpdateMeasurement")]
        public async Task<IActionResult> UpdateMeasurement(MeasurementDto model)
        {
            var apiResponse = new APIResponseModelDto<Measurement>();
            var ingModel = _mapper.Map<Measurement>(model);

            try
            {
                await _measurementService.UpdateMeasurementAsync(ingModel);

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

        [HttpPost("RemoveMeasurement")]
        public async Task<IActionResult> RemoveMeasurement(MeasurementDto model)
        {
            var apiResponse = new APIResponseModelDto<Measurement>();
            var ingModel = _mapper.Map<Measurement>(model);

            try
            {
                await _measurementService.RemoveMeasurementAsync(ingModel);

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
