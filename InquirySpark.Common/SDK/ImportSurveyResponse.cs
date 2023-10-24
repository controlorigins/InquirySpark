﻿using InquirySpark.Common.SDK.SurveyResponse;

namespace InquirySpark.Common.SDK;

public class ImportSurveyResponse
{
    public string SubmissionDT { get; set; }
    public DateTime CompletionDT { get; set; }
    public int SurveyID { get; set; }
    public string AssignmentDT { get; set; }
    public string CompletionStatus { get; set; }
    public SurveyResponseItem SurveyResponse { get; set; } = new SurveyResponseItem() { SurveyResponseID = -1 };
    public List<ImportSurveyResponseAnswer> Answers { get; set; } = new List<ImportSurveyResponseAnswer>();
    public string Process { get; set; }
    public string VersionID { get; set; }
}