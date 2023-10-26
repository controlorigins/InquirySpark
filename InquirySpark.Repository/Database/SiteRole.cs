using System;

namespace InquirySpark.Repository.Database;

public partial class SiteRole
{
    public int Id { get; set; }

    public string RoleName { get; set; } = null!;

    public bool Active { get; set; }

    public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; } = new List<ApplicationUser>();
}
