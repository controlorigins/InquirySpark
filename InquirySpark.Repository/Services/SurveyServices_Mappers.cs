using InquirySpark.Common.SDK;
using InquirySpark.Repository.Database;

namespace InquirySpark.Repository.Services
{
    public static class SurveyServices_Mappers
    {
        public static ApplicationItem Create(Application s)
        {
            return new ApplicationItem
            {
                ApplicationID = s.ApplicationId,
                ApplicationNM = s.ApplicationNm,
                ApplicationCD = s.ApplicationCd,
                ApplicationShortNM = s.ApplicationShortNm,
                ApplicationTypeID = s.ApplicationTypeId,
                ApplicationDS = s.ApplicationDs ?? string.Empty,
                MenuOrder = s.MenuOrder,
                ApplicationFolder = s.ApplicationFolder,
                DefaultAppPage = s.DefaultPageId,
                CompanyID = s.CompanyId ?? 0,
                ModifiedID = s.ModifiedId,
                ModifiedDT = s.ModifiedDt,
                ApplicationTypeNM = s.ApplicationType?.ApplicationTypeNm ?? "unknown",
                ApplicationSurveyList = Create(s.ApplicationSurveys),
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
    }
}
