using InquirySpark.Common.SDK;
using InquirySpark.Common.SDK.Services;
using Microsoft.AspNetCore.Mvc;

namespace InquirySpark.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ApplicationController(ISurveyService service, ILogger<ApplicationController> logger) : ControllerBase
{
    /// <summary>
    /// Get A collection of all Applications
    /// </summary>
    /// <returns>Application Collection</returns>
    [HttpGet("", Name = "GetApplicationCollection")]
    public async Task<ApplicationItem[]> GetApplicationCollection()
    {
        var Application = await service.GetApplicationItemCollection();
        return Application;
    }

    /// <summary>
    /// Get a Application by Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Application</returns>
    [HttpGet("{id}", Name = "GetApplicationById")]
    public async Task<ApplicationItem?> GetApplicationById(int id)
    {
        var Application = await service.GetApplicationByApplicationID(id);
        return Application;
    }

}
