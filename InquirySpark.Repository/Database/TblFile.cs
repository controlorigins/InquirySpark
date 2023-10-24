﻿using System;
using System.Collections.Generic;

namespace InquirySpark.Repository.Database;

public partial class TblFile
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string ContentType { get; set; } = null!;

    public byte[] Data { get; set; } = null!;
}
