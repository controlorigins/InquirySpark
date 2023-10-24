using InquirySpark.Common.SDK;
using InquirySpark.Common.SDK.Services;
using InquirySpark.Repository.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace InquirySpark.Repository.Services;



public class SurveyService : ISurveyService
{
    private readonly InquirySparkContext _coSurveyContext;
    private readonly ILogger<SurveyService> _logger;

    public SurveyService(InquirySparkContext coSurveyContext, ILogger<SurveyService> logger)
    {
        _coSurveyContext = coSurveyContext;
        _logger = logger;
    }



    public async Task<ApplicationItem?> GetApplicationByApplicationID(int ApplicationId)
    {
        var application = await _coSurveyContext
            .Applications
            .Where(w=>w.ApplicationId == ApplicationId)
            .Include(i => i.ApplicationType)
            .Include(i => i.Company)
            .Include(i => i.SurveyResponses)
            .Include(i => i.ApplicationSurveys)
            .Select(s => SurveyServices_Mappers.Create(s))
            .FirstOrDefaultAsync();
        return application;
    }

    public async Task<ApplicationItem[]> GetApplicationItemCollection()
    {
        var application = await _coSurveyContext
            .Applications
            .Include(i => i.ApplicationType)
            .Select(s => SurveyServices_Mappers.Create(s))
            .ToArrayAsync();
        return application;
    }

    public Task<ApplicationTypeItem> GetApplicationTypeByApplicationTypeID(ApplicationTypeItem applicationType)
    {
        throw new NotImplementedException();
    }

    public Task<ApplicationTypeItem> GetApplicationTypeByApplicationTypeID(int applicationTypeId)
    {
        throw new NotImplementedException();
    }

    public Task<ApplicationTypeItem[]> GetApplicationTypeCollection()
    {
        throw new NotImplementedException();
    }

    public async Task<CompanyItem?> GetCompanyByCompanyId(int CompanyId)
    {
        var company = await _coSurveyContext
            .Companies.Where(w => w.CompanyId == CompanyId)
            .Include(i => i.Applications)
            .Include(i => i.ApplicationUsers)
            .Select(s => SurveyServices_Mappers.Create(s))
            .FirstOrDefaultAsync();
        return company;
    }

    public async Task<CompanyItem[]> GetCompanyCollection()
    {
        var company = await _coSurveyContext
            .Companies
            .Include(i => i.Applications)
            .Select(s => SurveyServices_Mappers.Create(s))
            .ToArrayAsync();
        return company;
    }

    public Task<SurveyItem> GetSurveyBySurveyId(int surveyId)
    {
        throw new NotImplementedException();
    }

    public Task<SurveyItem[]> GetSurveyCollection()
    {
        throw new NotImplementedException();
    }

    public Task<SurveyTypeItem> GetSurveyType(int surveyTypeId)
    {
        throw new NotImplementedException();
    }

    public Task<SurveyTypeItem[]> GetSurveyTypeCollection(int surveyTypeId)
    {
        throw new NotImplementedException();
    }

    public Task<ApplicationUserItem> GetUserById(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<ApplicationUserItem[]> GetUserCollection()
    {
        throw new NotImplementedException();
    }

    public Task<ApplicationItem> PutApplication(ApplicationItem applicationItem)
    {
        throw new NotImplementedException();
    }

    public Task<CompanyItem> PutCompany(CompanyItem company)
    {
        throw new NotImplementedException();
    }

    public Task<SurveyItem> PutSurvey(SurveyItem survey)
    {
        throw new NotImplementedException();
    }

    public Task<ApplicationUserItem> PutUser(ApplicationUserItem userItem)
    {
        throw new NotImplementedException();
    }
}
