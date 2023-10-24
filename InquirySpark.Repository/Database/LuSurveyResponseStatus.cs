using System;
using System.Collections.Generic;

namespace InquirySpark.Repository.Database;

public partial class LuSurveyResponseStatus
{
    public int StatusId { get; set; }

    public string StatusNm { get; set; } = null!;

    public string StatusDs { get; set; } = null!;

    public string? EmailTemplate { get; set; }

    public int PreviousStatusId { get; set; }

    public int NextStatusId { get; set; }

    public int ModifiedId { get; set; }

    public DateTime ModifiedDt { get; set; }

    public virtual ICollection<SurveyResponseState> SurveyResponseStates { get; set; } = new List<SurveyResponseState>();
}
