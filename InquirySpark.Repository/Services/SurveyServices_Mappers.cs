using InquirySpark.Common.SDK;
using InquirySpark.Repository.Database;

namespace InquirySpark.Repository.Services;

/// <summary>
/// SurveyServices_Mappers
/// </summary>
public static class SurveyServices_Mappers
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public static ApplicationItem Create(Application item)
    {
        return new ApplicationItem
        {
            ApplicationID = item.ApplicationId,
            ApplicationNM = item.ApplicationNm,
            ApplicationCD = item.ApplicationCd,
            ApplicationShortNM = item.ApplicationShortNm,
            ApplicationTypeID = item.ApplicationTypeId,
            ApplicationDS = item.ApplicationDs ?? string.Empty,
            MenuOrder = item.MenuOrder,
            ApplicationFolder = item.ApplicationFolder,
            DefaultAppPage = item.DefaultPageId,
            CompanyID = item.CompanyId ?? 0,
            ModifiedID = item.ModifiedId,
            ModifiedDT = item.ModifiedDt,
            ApplicationTypeNM = item.ApplicationType?.ApplicationTypeNm ?? "unknown",
            ApplicationSurveyList = Create(item.ApplicationSurveys),
        };
    }
    public static List<ApplicationSurveyItem> Create(ICollection<ApplicationSurvey>? applicationSurveys)
    {
        List<ApplicationSurveyItem> applicationSurveyItems = [];
        if (applicationSurveys == null) return applicationSurveyItems;

        foreach (var item in applicationSurveys)
        {
            applicationSurveyItems.Add(Create(item));
        }
        return applicationSurveyItems;
    }

    public static ApplicationSurveyItem Create(ApplicationSurvey item)
    {
        return new ApplicationSurveyItem
        {
            ApplicationSurveyID = item.ApplicationSurveyId,
            ApplicationID = item.ApplicationId,
            Survey = Create(item.Survey),
        };
    }
    public static SurveyItem Create(Survey survey)
    {
        return new SurveyItem
        {
            SurveyID = survey.SurveyId,
            SurveyNM = survey.SurveyNm,
            SurveyDS = survey.SurveyDs ?? string.Empty,
            StartDT = survey.StartDt,
            EndDT = survey.EndDt,
            StatusList = Create(survey.SurveyStatuses),
        };

    }
    public static List<SurveyStatusItem> Create(ICollection<SurveyStatus>? surveyStatuses)
    {
        List<SurveyStatusItem> surveyStatusItems = [];
        if (surveyStatuses == null) return surveyStatusItems;

        foreach (var item in surveyStatuses)
        {
            surveyStatusItems.Add(Create(item));
        }
        return surveyStatusItems;
    }
    public static SurveyStatusItem Create(SurveyStatus item)
    {
        return new SurveyStatusItem
        {
            SurveyStatusID = item.SurveyStatusId,
            SurveyID = item.SurveyId,
            StatusID = item.StatusId,
            StatusNM = item.StatusNm,
            StatusDS = item.StatusDs ?? string.Empty,
            SubjectTemplate = item.EmailSubjectTemplate ?? string.Empty,
            BodyTemplate = item.EmailTemplate ?? string.Empty,
            ModifiedID = item.ModifiedId,
            NextStatusID = item.NextStatusId,
            PreviousStatusID = item.PreviousStatusId,
        };
    }

    public static CompanyItem[] Create(Company[] company)
    {
        int companyCount = company.Length;
        CompanyItem[] companyItemArray = new CompanyItem[companyCount];

        for (int i = 0; i < companyCount; i++)
        {
            var item = company[i];
            companyItemArray[i] = Create(item);
        }
        return companyItemArray;
    }

    public static CompanyItem Create(Company item)
    {
        return new CompanyItem
        {
            CompanyID = item.CompanyId,
            CompanyNM = item.CompanyNm,
            CompanyCD = item.CompanyCd,
            CompanyDS = item.CompanyDs ?? item.CompanyNm,
            Title = item.Title,
            SiteTheme = item.Theme,
            DefaultSiteTheme = item.DefaultTheme,
            GalleryFolder = item.GalleryFolder,
            Address1 = item.Address1,
            Address2 = item.Address2 ?? string.Empty,
            City = item.City,
            State = item.State,
            Country = item.Country,
            PostalCode = item.PostalCode,
            SiteURL = item.SiteUrl,
            FromEmail = item.FromEmail ?? string.Empty,
            SMTP = item.Smtp ?? string.Empty,
            Component = item.Component ?? string.Empty,
            ModifiedID = item.ModifiedId,
            ModifiedDT = item.ModifiedDt,
            Active = item.ActiveFl,
            ProjectCount = item.Applications?.Count ?? 0,
            UserCount = item.ApplicationUsers?.Count ?? 0,
            SurveyResponseCount = 0,
            UserList = Create(item.ApplicationUsers),
            ProjectList = Create(item.Applications)
        };
    }

    public static List<ApplicationItem> Create(ICollection<Application>? applications)
    {
        List<ApplicationItem> applicationItems = [];
        if (applications == null) return applicationItems;

        foreach (var item in applications)
        {
            applicationItems.Add(Create(item));
        }
        return applicationItems;
    }

    public static List<ApplicationUserItem> Create(ICollection<ApplicationUser>? applicationUsers)
    {
        List<ApplicationUserItem> applicationUserItems = [];

        if (applicationUsers == null) return applicationUserItems;

        foreach (var item in applicationUsers)
        {
            applicationUserItems.Add(new ApplicationUserItem
            {
                ApplicationUserID = item.ApplicationUserId,
                AccountNM = item.AccountNm,
                CompanyID = item.CompanyId ?? 0,
                ModifiedID = item.ModifiedId,
                ModifiedDT = item.ModifiedDt,
            });
        }
        return applicationUserItems;

    }

    public static ApplicationTypeItem Create(LuApplicationType s)
    {
        return new ApplicationTypeItem()
        {
            ApplicationTypeID = s.ApplicationTypeId,
            ApplicationTypeNM = s.ApplicationTypeNm,
            ApplicationTypeDS = s.ApplicationTypeDs ?? string.Empty,
            ModifiedID = s.ModifiedId,
            ModifiedDT = s.ModifiedDt,
        };
    }
    public static SurveyTypeItem Create(LuSurveyType s)
    {
        return new SurveyTypeItem()
        {
            SurveyTypeID = s.SurveyTypeId,
            SurveyTypeShortNM = s.SurveyTypeShortNm,
            SurveyTypeNM = s.SurveyTypeNm,
            SurveyTypeDS = s.SurveyTypeDs ?? string.Empty,
            SurveyTypeComment = s.SurveyTypeComment ?? string.Empty,
            ApplicationTypeID = s.ApplicationTypeId,
            MultiSequence = s.MutiSequenceFl,
            ParentSurveyTypeID = s.ParentSurveyTypeId ?? 0,
            ParentSurveyTypeNM = s.SurveyTypeNm,
            LevelNumber = 0,
            TreeSort = string.Empty,
            ModifiedID = s.ModifiedId,
            ModifiedDT = s.ModifiedDt,
            QuestionCount = s.Questions?.Count ?? 0,
            SurveyCount = s.Surveys?.Count??0,
            ChildCount = 0,
        };
    }

    public static ApplicationUserItem Create(ApplicationUser s)
    {
        return new ApplicationUserItem()
        {
            ApplicationUserID = s.ApplicationUserId,
            AccountNM = s.AccountNm,
            FirstNM = s.FirstNm,
            LastNM = s.LastNm,
            EMailAddress = s.EMailAddress,
            CommentDS = s.CommentDs ?? string.Empty,
            CompanyID = s.CompanyId ?? 0,
            CompanyNM = s.Company?.CompanyNm ?? string.Empty,
            SupervisorAccountNM = s.SupervisorAccountNm ?? string.Empty,
            LastLoginDT = s.LastLoginDt ?? DateTime.MinValue,
            LastLoginLocation = s.LastLoginLocation ?? string.Empty,
            ModifiedID = s.ModifiedId,
            ModifiedDT = s.ModifiedDt,
            UserRoleID = s.RoleId
        };
    }
}
