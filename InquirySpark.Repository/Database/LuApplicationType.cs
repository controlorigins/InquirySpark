using System;
using System.Collections.Generic;

namespace InquirySpark.Repository.Database;

public partial class LuApplicationType
{
    public int ApplicationTypeId { get; set; }

    public string ApplicationTypeNm { get; set; } = null!;

    public string? ApplicationTypeDs { get; set; }

    public int ModifiedId { get; set; }

    public DateTime ModifiedDt { get; set; }

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
}
