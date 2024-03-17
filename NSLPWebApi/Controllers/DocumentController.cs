using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSLPWebApi.Dto;
using NSLPWebApi.DTO;
using NSLPWebApi.Models;
using NSLPWebApi.Services.DocumentService;

namespace NSLPWebApi.Controllers
{
    [EnableCors("AllowedOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _documentService;
        private readonly IMapper _mapper;

        public DocumentController(IDocumentService documentService, IMapper mapper)
        {
            _documentService = documentService;
            _mapper = mapper;
        }

        [HttpGet("GetAllDocument")]
        public async Task<IActionResult> GetAllDocument()
        {
            try
            {
                var apiResponse = new APIResponseModelDto<List<Document>>();
                var ing = await _documentService.GetAllDocumentAsync();

                apiResponse.Data = ing;
                apiResponse.Error = false;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddDocument")]
        public async Task<IActionResult> AddDocument(DocumentDto model)
        {
            var apiResponse = new APIResponseModelDto<Document>();
            var ingModel = _mapper.Map<Document>(model);

            try
            {
                await _documentService.AddDocumentAsync(ingModel);

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

        [HttpPost("UpdateDocument")]
        public async Task<IActionResult> UpdateDocument(DocumentDto model)
        {
            var apiResponse = new APIResponseModelDto<Document>();
            var ingModel = _mapper.Map<Document>(model);

            try
            {
                await _documentService.UpdateDocumentAsync(ingModel);

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

        [HttpPost("RemoveDocument")]
        public async Task<IActionResult> RemoveDocument(DocumentDto model)
        {
            var apiResponse = new APIResponseModelDto<Document>();
            var ingModel = _mapper.Map<Document>(model);

            try
            {
                await _documentService.RemoveDocumentAsync(ingModel);

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
