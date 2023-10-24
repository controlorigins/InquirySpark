using System;
using System.Collections.Generic;

namespace InquirySpark.Repository.Database;

public partial class SurveyResponse
{
    public int SurveyResponseId { get; set; }

    public string SurveyResponseNm { get; set; } = null!;

    public int SurveyId { get; set; }

    public int ApplicationId { get; set; }

    public int? AssignedUserId { get; set; }

    public int StatusId { get; set; }

    public string DataSource { get; set; } = null!;

    public int ModifiedId { get; set; }

    public DateTime ModifiedDt { get; set; }

    public virtual Application Application { get; set; } = null!;

    public virtual ApplicationUser? AssignedUser { get; set; }

    public virtual Survey Survey { get; set; } = null!;

    public virtual ICollection<SurveyResponseHistory> SurveyResponseHistories { get; set; } = new List<SurveyResponseHistory>();

    public virtual ICollection<SurveyResponseSequence> SurveyResponseSequences { get; set; } = new List<SurveyResponseSequence>();

    public virtual ICollection<SurveyResponseState> SurveyResponseStates { get; set; } = new List<SurveyResponseState>();
}
