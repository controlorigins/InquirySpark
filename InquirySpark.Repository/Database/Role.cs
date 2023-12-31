﻿using System;

namespace InquirySpark.Repository.Database;

public partial class Role
{
    public int RoleId { get; set; }

    public string RoleCd { get; set; } = null!;

    public string RoleNm { get; set; } = null!;

    public string RoleDs { get; set; } = null!;

    public int ReviewLevel { get; set; }

    public bool ReadFl { get; set; }

    public bool UpdateFl { get; set; }

    public int ModifiedId { get; set; }

    public DateTime ModifiedDt { get; set; }

    public virtual ICollection<ApplicationSurvey> ApplicationSurveys { get; set; } = new List<ApplicationSurvey>();

    public virtual ICollection<ApplicationUserRole> ApplicationUserRoles { get; set; } = new List<ApplicationUserRole>();
}
