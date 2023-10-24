using System;
using System.Collections.Generic;

namespace InquirySpark.Repository.Database;

public partial class ApplicationUser
{
    public int ApplicationUserId { get; set; }

    public string FirstNm { get; set; } = null!;

    public string LastNm { get; set; } = null!;

    public string EMailAddress { get; set; } = null!;

    public string? CommentDs { get; set; }

    public string AccountNm { get; set; } = null!;

    public string? SupervisorAccountNm { get; set; }

    public DateTime? LastLoginDt { get; set; }

    public string? LastLoginLocation { get; set; }

    public string DisplayName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int RoleId { get; set; }

    public Guid UserKey { get; set; }

    public string UserLogin { get; set; } = null!;

    public bool EmailVerified { get; set; }

    public string VerifyCode { get; set; } = null!;

    public int? CompanyId { get; set; }

    public int ModifiedId { get; set; }

    public DateTime ModifiedDt { get; set; }

    public virtual ICollection<ApplicationUserRole> ApplicationUserRoles { get; set; } = new List<ApplicationUserRole>();

    public virtual Company? Company { get; set; }

    public virtual SiteRole Role { get; set; } = null!;

    public virtual ICollection<SurveyResponseState> SurveyResponseStates { get; set; } = new List<SurveyResponseState>();

    public virtual ICollection<SurveyResponse> SurveyResponses { get; set; } = new List<SurveyResponse>();

    public virtual ICollection<UserAppProperty> UserAppProperties { get; set; } = new List<UserAppProperty>();

    public virtual ICollection<UserMessage> UserMessageFromUsers { get; set; } = new List<UserMessage>();

    public virtual ICollection<UserMessage> UserMessageToUsers { get; set; } = new List<UserMessage>();
}
