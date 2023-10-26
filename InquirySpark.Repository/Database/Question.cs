using System;

namespace InquirySpark.Repository.Database;

public partial class Question
{
    public int QuestionId { get; set; }

    public int SurveyTypeId { get; set; }

    public string QuestionShortNm { get; set; } = null!;

    public string QuestionNm { get; set; } = null!;

    public string QuestionDs { get; set; } = null!;

    public string? Keywords { get; set; }

    public int QuestionSort { get; set; }

    public int ReviewRoleLevel { get; set; }

    public int QuestionTypeId { get; set; }

    public bool CommentFl { get; set; }

    public int QuestionValue { get; set; }

    public int UnitOfMeasureId { get; set; }

    public int ModifiedId { get; set; }

    public DateTime ModifiedDt { get; set; }

    public byte[]? FileData { get; set; }

    public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; } = new List<QuestionAnswer>();

    public virtual ICollection<QuestionGroupMember> QuestionGroupMembers { get; set; } = new List<QuestionGroupMember>();

    public virtual LuQuestionType QuestionType { get; set; } = null!;

    public virtual ICollection<SurveyResponseAnswer> SurveyResponseAnswers { get; set; } = new List<SurveyResponseAnswer>();

    public virtual LuSurveyType SurveyType { get; set; } = null!;

    public virtual LuUnitOfMeasure UnitOfMeasure { get; set; } = null!;
}
