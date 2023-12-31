﻿using System;

namespace InquirySpark.Repository.Database;

public partial class AppProperty
{
    public int Id { get; set; }

    public int SiteAppId { get; set; }

    public string Key { get; set; } = null!;

    public string? Value { get; set; }

    public virtual Application SiteApp { get; set; } = null!;
}
