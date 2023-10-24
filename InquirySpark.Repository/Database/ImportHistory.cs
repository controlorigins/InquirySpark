using System;
using System.Collections.Generic;

namespace InquirySpark.Repository.Database;

public partial class ImportHistory
{
    public int ImportHistoryId { get; set; }

    public string FileName { get; set; } = null!;

    public string ImportType { get; set; } = null!;

    public int NumberOfRows { get; set; }

    public string? ImportLog { get; set; }

    public int ModifiedId { get; set; }

    public DateTime ModifiedDt { get; set; }
}
