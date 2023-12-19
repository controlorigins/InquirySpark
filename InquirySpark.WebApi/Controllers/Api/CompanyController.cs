using InquirySpark.Common.SDK;
using InquirySpark.Common.SDK.Services;
using InquirySpark.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace InquirySpark.WebApi.Controllers.Api;

/// <summary>
/// CompanyController
/// </summary>
/// <remarks>
/// CompanyController constructor
/// </remarks>
/// <param name="service"></param>
/// <param name="logger"></param>
public class CompanyController(ISurveyService service, ILogger<CompanyController> logger) : SurveyApiController(service, logger)
{

    /// <summary>
    /// Get A collection of all Companies
    /// </summary>
    /// <returns>Company Collection</returns>
    [HttpGet("", Name = "GetCompanyCollection")]
    [SwaggerOperation(Summary = "Get Company Collection")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CompanyItem[]))]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
    public async Task<IActionResult> GetCompanyCollection()
    {
        return await ApiResponseHelper.ExecuteAsync(() => _service.GetCompanyCollection(), _logger);
    }

    /// <summary>
    /// Get a Company by Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Company</returns>
    [HttpGet("{id}", Name = "GetCompanyById")]
    [SwaggerOperation(Summary = "Get a Company by Id")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CompanyItem))]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
    public async Task<IActionResult> GetCompanyById(int id)
    {
        return await ApiResponseHelper.ExecuteAsync(() => _service.GetCompanyByCompanyId(id), _logger);
    }

}

