﻿using System;

namespace InquirySpark.Repository.Database;

public partial class LuSurveyType
{
    public int SurveyTypeId { get; set; }

    public string SurveyTypeShortNm { get; set; } = null!;

    public string SurveyTypeNm { get; set; } = null!;

    public string? SurveyTypeDs { get; set; }

    public string? SurveyTypeComment { get; set; }

    public int ApplicationTypeId { get; set; }

    public int? ParentSurveyTypeId { get; set; }

    public bool MutiSequenceFl { get; set; }

    public int ModifiedId { get; set; }

    public DateTime ModifiedDt { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual ICollection<Survey> Surveys { get; set; } = new List<Survey>();
}
