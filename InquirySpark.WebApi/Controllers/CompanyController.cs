using InquirySpark.Common.SDK;
using InquirySpark.Common.SDK.Services;
using Microsoft.AspNetCore.Mvc;

namespace InquirySpark.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CompanyController(ISurveyService service, ILogger<CompanyController> logger) : ControllerBase
{
    /// <summary>
    /// Get A collection of all Companies
    /// </summary>
    /// <returns>Company Collection</returns>
    [HttpGet("", Name = "GetCompanyCollection")]
    public async Task<CompanyItem[]> GetCompanyCollection()
    {
        var company = await service.GetCompanyCollection();
        return company;
    }

    /// <summary>
    /// Get a Company by Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Company</returns>
    [HttpGet("{id}", Name = "GetCompanyById")]
    public async Task<CompanyItem?> GetCompanyById(int id)
    {
        var company = await service.GetCompanyByCompanyId(id);
        return company;
    }

}

