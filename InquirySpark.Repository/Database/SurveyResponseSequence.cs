using System;
using System.Collections.Generic;

namespace InquirySpark.Repository.Database;

public partial class SurveyResponseSequence
{
    public int SurveyResponseSequenceId { get; set; }

    public int SurveyResponseId { get; set; }

    public int SequenceNumber { get; set; }

    public string? SequenceText { get; set; }

    public int ModifiedId { get; set; }

    public DateTime ModifiedDt { get; set; }

    public virtual SurveyResponse SurveyResponse { get; set; } = null!;

    public virtual ICollection<SurveyResponseAnswer> SurveyResponseAnswers { get; set; } = new List<SurveyResponseAnswer>();
}
