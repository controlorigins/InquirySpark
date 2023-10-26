using InquirySpark.Common.SDK.Services;
using Microsoft.AspNetCore.Mvc;

namespace InquirySpark.WebApi.Controllers.Api;

/// <summary>
/// SurveyApiController
/// </summary>
/// <param name="service"></param>
/// <param name="logger"></param>
[ApiController]
[Route("[controller]")]
public class SurveyApiController(ISurveyService service, ILogger logger) : ControllerBase
{
    /// <summary>
    /// ISurveyService instance
    /// </summary>
    protected readonly ISurveyService _service = service;
    /// <summary>
    /// ILogger instance
    /// </summary>
    protected readonly ILogger _logger = logger;
}
