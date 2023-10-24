using System;
using System.Collections.Generic;

namespace InquirySpark.Repository.Database;

public partial class Survey
{
    public int SurveyId { get; set; }

    public int SurveyTypeId { get; set; }

    public bool UseQuestionGroupsFl { get; set; }

    public string SurveyNm { get; set; } = null!;

    public string SurveyShortNm { get; set; } = null!;

    public string SurveyDs { get; set; } = null!;

    public string CompletionMessage { get; set; } = null!;

    public string? ResponseNmtemplate { get; set; }

    public string? ReviewerAccountNm { get; set; }

    public string? AutoAssignFilter { get; set; }

    public DateTime? StartDt { get; set; }

    public DateTime? EndDt { get; set; }

    public int? ParentSurveyId { get; set; }

    public int ModifiedId { get; set; }

    public DateTime ModifiedDt { get; set; }

    public virtual ICollection<ApplicationSurvey> ApplicationSurveys { get; set; } = new List<ApplicationSurvey>();

    public virtual ICollection<QuestionGroup> QuestionGroups { get; set; } = new List<QuestionGroup>();

    public virtual ICollection<SurveyEmailTemplate> SurveyEmailTemplates { get; set; } = new List<SurveyEmailTemplate>();

    public virtual ICollection<SurveyResponse> SurveyResponses { get; set; } = new List<SurveyResponse>();

    public virtual ICollection<SurveyReviewStatus> SurveyReviewStatuses { get; set; } = new List<SurveyReviewStatus>();

    public virtual ICollection<SurveyStatus> SurveyStatuses { get; set; } = new List<SurveyStatus>();

    public virtual LuSurveyType SurveyType { get; set; } = null!;
}
