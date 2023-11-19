using System;
using System.Collections.Generic;

namespace EntityFrameworkL5.Models;

public partial class Cart : BaseEntity
{
    public int UserId { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
