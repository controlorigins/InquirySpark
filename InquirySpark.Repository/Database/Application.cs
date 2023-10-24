namespace InquirySpark.Repository.Database;

public partial class Application
{
    public int ApplicationId { get; set; }

    public string ApplicationNm { get; set; } = null!;

    public string ApplicationCd { get; set; } = null!;

    public string ApplicationShortNm { get; set; } = null!;

    public int ApplicationTypeId { get; set; }

    public string? ApplicationDs { get; set; }

    public int MenuOrder { get; set; }

    public string ApplicationFolder { get; set; } = null!;

    public int DefaultPageId { get; set; }

    public int? CompanyId { get; set; }

    public int ModifiedId { get; set; }

    public DateTime ModifiedDt { get; set; }

    public virtual ICollection<AppProperty> AppProperties { get; set; } = new List<AppProperty>();

    public virtual ICollection<ApplicationSurvey> ApplicationSurveys { get; set; } = new List<ApplicationSurvey>();

    public virtual LuApplicationType ApplicationType { get; set; } = null!;

    public virtual ICollection<ApplicationUserRole> ApplicationUserRoles { get; set; } = new List<ApplicationUserRole>();

    public virtual Company? Company { get; set; }

    public virtual ICollection<SiteAppMenu> SiteAppMenus { get; set; } = new List<SiteAppMenu>();

    public virtual ICollection<SurveyResponse> SurveyResponses { get; set; } = new List<SurveyResponse>();

    public virtual ICollection<UserAppProperty> UserAppProperties { get; set; } = new List<UserAppProperty>();
}
