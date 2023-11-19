using System;
using System.Collections.Generic;

namespace EntityFrameworkL5.Models;

public partial class KeyLink : BaseEntity
{
    public virtual Word KeyWords { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
