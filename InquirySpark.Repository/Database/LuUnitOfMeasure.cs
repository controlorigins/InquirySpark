using System;

namespace InquirySpark.Repository.Database;

public partial class LuUnitOfMeasure
{
    public int UnitOfMeasureId { get; set; }

    public string UnitOfMeasureNm { get; set; } = null!;

    public string? UnitOfMeasureDs { get; set; }

    public int ModifiedId { get; set; }

    public DateTime ModifiedDt { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}
