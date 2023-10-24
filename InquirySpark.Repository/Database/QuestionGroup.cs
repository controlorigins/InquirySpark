using System;
using System.Collections.Generic;

namespace InquirySpark.Repository.Database;

public partial class QuestionGroup
{
    public int QuestionGroupId { get; set; }

    public int SurveyId { get; set; }

    public int GroupOrder { get; set; }

    public string QuestionGroupShortNm { get; set; } = null!;

    public string QuestionGroupNm { get; set; } = null!;

    public string? QuestionGroupDs { get; set; }

    public decimal QuestionGroupWeight { get; set; }

    public string? GroupHeader { get; set; }

    public string? GroupFooter { get; set; }

    public int ModifiedId { get; set; }

    public DateTime ModifiedDt { get; set; }

    public int? DependentQuestionGroupId { get; set; }

    public decimal? DependentMinScore { get; set; }

    public decimal? DependentMaxScore { get; set; }

    public virtual ICollection<QuestionGroupMember> QuestionGroupMembers { get; set; } = new List<QuestionGroupMember>();

    public virtual Survey Survey { get; set; } = null!;
}
