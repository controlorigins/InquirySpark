﻿using System;

namespace InquirySpark.Repository.Database;

public partial class LuReviewStatus
{
    public int ReviewStatusId { get; set; }

    public string ReviewStatusNm { get; set; } = null!;

    public string ReviewStatusDs { get; set; } = null!;

    public bool ApprovedFl { get; set; }

    public bool CommentFl { get; set; }

    public int ModifiedId { get; set; }

    public DateTime ModifiedDt { get; set; }
}
