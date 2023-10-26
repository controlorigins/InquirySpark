using InquirySpark.Common.Models;
using InquirySpark.Common.SDK;
using InquirySpark.Common.SDK.Services;
using InquirySpark.Repository.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace InquirySpark.Repository.Services;

/// <summary>
/// Survey Service
/// </summary>
public class SurveyService : ISurveyService
{
    private readonly InquirySparkContext _coSurveyContext;
    private readonly ILogger<SurveyService> _logger;

    /// <summary>
    /// Survey Service Constructor
    /// </summary>
    /// <param name="coSurveyContext"></param>
    /// <param name="logger"></param>
    public SurveyService(InquirySparkContext coSurveyContext, ILogger<SurveyService> logger)
    {
        _coSurveyContext = coSurveyContext;
        _logger = logger;
    }

    /// <summary>
    /// GetApplicationByApplicationID
    /// </summary>
    /// <param name="ApplicationId"></param>
    /// <returns></returns>
    public async Task<BaseResponse<ApplicationItem>> GetApplicationByApplicationID(int ApplicationId)
    {
        return await DbContextHelper.ExecuteAsync(async () =>
        {
            return await _coSurveyContext
                .Applications
                .Where(w => w.ApplicationId == ApplicationId)
                .Include(i => i.ApplicationType)
                .Include(i => i.Company)
                .Include(i => i.SurveyResponses)
                .Include(i => i.ApplicationSurveys)
                .Select(s => SurveyServices_Mappers.Create(s))
                .FirstOrDefaultAsync();
        });
    }

    public async Task<BaseResponseCollection<ApplicationItem>> GetApplicationItemCollection()
    {
        return await DbContextHelper.ExecuteCollectionAsync<ApplicationItem>(async () =>
        {
            return await _coSurveyContext
            .Applications
            .Include(i => i.ApplicationType)
            .Select(s => SurveyServices_Mappers.Create(s))
            .ToListAsync();
        });
    }

    public async Task<BaseResponse<ApplicationTypeItem>> GetApplicationTypeByApplicationTypeID(ApplicationTypeItem applicationType)
    {
        return await DbContextHelper.ExecuteAsync(async () =>
        {
            return await _coSurveyContext
                .LuApplicationTypes
                .Where(w => w.ApplicationTypeId == applicationType.ApplicationTypeID)
                .Select(s => SurveyServices_Mappers.Create(s))
                .FirstOrDefaultAsync();
        });
    }

    public async Task<BaseResponse<ApplicationTypeItem>> GetApplicationTypeByApplicationTypeID(int applicationTypeId)
    {
        return await DbContextHelper.ExecuteAsync(async () =>
        {
            return await _coSurveyContext
                .LuApplicationTypes
                .Where(w => w.ApplicationTypeId == applicationTypeId)
                .Select(s => SurveyServices_Mappers.Create(s))
                .FirstOrDefaultAsync();
        });
    }

    public async Task<BaseResponseCollection<ApplicationTypeItem>> GetApplicationTypeCollection()
    {
        return await DbContextHelper.ExecuteCollectionAsync<ApplicationTypeItem>(async () =>
        {
            return await _coSurveyContext
            .LuApplicationTypes
            .Select(s => SurveyServices_Mappers.Create(s))
            .ToListAsync();
        });
    }

    public async Task<BaseResponse<CompanyItem>> GetCompanyByCompanyId(int CompanyId)
    {
        return await DbContextHelper.ExecuteAsync(async () =>
        {
            return await _coSurveyContext
            .Companies.Where(w => w.CompanyId == CompanyId)
            .Include(i => i.Applications)
            .Include(i => i.ApplicationUsers)
            .Select(s => SurveyServices_Mappers.Create(s))
            .FirstOrDefaultAsync();
        });

    }

    public async Task<BaseResponseCollection<CompanyItem>> GetCompanyCollection()
    {
        return await DbContextHelper.ExecuteCollectionAsync<CompanyItem>(async () =>
        {
            return await _coSurveyContext
            .Companies
            .Include(i => i.Applications)
            .Select(s => SurveyServices_Mappers.Create(s))
            .ToListAsync();
        });
    }

    public Task<BaseResponse<SurveyItem>> GetSurveyBySurveyId(int surveyId)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponseCollection<SurveyItem>> GetSurveyCollection()
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<SurveyTypeItem>> GetSurveyType(int surveyTypeId)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponseCollection<SurveyTypeItem>> GetSurveyTypeCollection(int surveyTypeId)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<ApplicationUserItem>> GetUserById(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponseCollection<ApplicationUserItem>> GetUserCollection()
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<ApplicationItem>> PutApplication(ApplicationItem applicationItem)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<CompanyItem>> PutCompany(CompanyItem company)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<SurveyItem>> PutSurvey(SurveyItem survey)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<ApplicationUserItem>> PutUser(ApplicationUserItem userItem)
    {
        throw new NotImplementedException();
    }
}
