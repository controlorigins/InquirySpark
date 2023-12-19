using InquirySpark.Common.SDK;
using InquirySpark.Common.SDK.Services;
using InquirySpark.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace InquirySpark.WebApi.Controllers.Api;

/// <summary>
/// SurveyController
/// </summary>
/// <remarks>
/// SurveyController constructor
/// </remarks>
/// <param name="service"></param>
/// <param name="logger"></param>
public class SurveyController(ISurveyService service, ILogger<SurveyController> logger) : SurveyApiController(service, logger)
{

    /// <summary>
    /// Get A collection of all Surveys
    /// </summary>
    /// <returns>Survey Collection</returns>
    [HttpGet("", Name = "GetSurveyCollection")]
    [SwaggerOperation(Summary = "Get Survey Collection")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SurveyItem[]))]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
    public async Task<IActionResult> GetSurveyCollection()
    {
        return await ApiResponseHelper.ExecuteAsync(() => _service.GetSurveyCollection(), _logger);
    }

    /// <summary>
    /// Get a Survey by Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Survey</returns>
    [HttpGet("{id}", Name = "GetSurveyById")]
    [SwaggerOperation(Summary = "Get an Survey by Id")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SurveyItem))]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
    public async Task<IActionResult> GetSurveyById(int id)
    {
        return await ApiResponseHelper.ExecuteAsync(() => _service.GetSurveyBySurveyId(id), _logger);
    }

}
