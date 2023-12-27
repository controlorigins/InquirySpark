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
/// Question constructor
/// </remarks>
/// <param name="service"></param>
/// <param name="logger"></param>
public class QuestionController(ISurveyService service, ILogger<SurveyController> logger) : SurveyApiController(service, logger)
{

    /// <summary>
    /// Get A collection of all Questions
    /// </summary>
    /// <returns>Questions Collection</returns>
    [HttpGet("", Name = "GetQuestionCollection")]
    [SwaggerOperation(Summary = "Get Question Collection")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(QuestionItem[]))]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
    public async Task<IActionResult> GetQuestionCollection()
    {
        return await ApiResponseHelper.ExecuteAsync(() => _service.GetQuestionCollection(), _logger);
    }

    /// <summary>
    /// Get a Question by Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Question</returns>
    [HttpGet("{id}", Name = "GetQuestionById")]
    [SwaggerOperation(Summary = "Get an Question by Id")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(QuestionItem))]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
    public async Task<IActionResult> GetQuestionById(int id)
    {
        return await ApiResponseHelper.ExecuteAsync(() => _service.GetQuestionByQuestionId(id), _logger);
    }

}
