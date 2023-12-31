﻿using System;

namespace InquirySpark.Repository.Database;

public partial class QuestionAnswer
{
    public int QuestionAnswerId { get; set; }

    public int QuestionId { get; set; }

    public int QuestionAnswerSort { get; set; }

    public string QuestionAnswerShortNm { get; set; } = null!;

    public string QuestionAnswerNm { get; set; } = null!;

    public int QuestionAnswerValue { get; set; }

    public string QuestionAnswerDs { get; set; } = null!;

    public bool CommentFl { get; set; }

    public bool ActiveFl { get; set; }

    public int ModifiedId { get; set; }

    public DateTime ModifiedDt { get; set; }

    public virtual Question Question { get; set; } = null!;

    public virtual ICollection<SurveyResponseAnswer> SurveyResponseAnswers { get; set; } = new List<SurveyResponseAnswer>();
}
