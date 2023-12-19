using InquirySpark.Common.SDK;
using InquirySpark.Common.SDK.Services;
using InquirySpark.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace InquirySpark.WebApi.Controllers.Api;

/// <summary>
/// ApplicationController
/// </summary>
/// <remarks>
/// ApplicationController constructor
/// </remarks>
/// <param name="service"></param>
/// <param name="logger"></param>
public class ApplicationController(ISurveyService service, ILogger<ApplicationController> logger) : SurveyApiController(service, logger)
{

    /// <summary>
    /// Get A collection of all Applications
    /// </summary>
    /// <returns>Application Collection</returns>
    [HttpGet("", Name = "GetApplicationCollection")]
    [SwaggerOperation(Summary = "Get Application Collection")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApplicationItem[]))]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
    public async Task<IActionResult> GetApplicationCollection()
    {
        return await ApiResponseHelper.ExecuteAsync(() => _service.GetApplicationItemCollection(), _logger);
    }

    /// <summary>
    /// Get a Application by Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Application</returns>
    [HttpGet("{id}", Name = "GetApplicationById")]
    [SwaggerOperation(Summary = "Get an Application by Id")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApplicationItem))]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
    public async Task<IActionResult> GetApplicationById(int id)
    {
        return await ApiResponseHelper.ExecuteAsync(() => _service.GetApplicationByApplicationID(id), _logger);
    }
}
