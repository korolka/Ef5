using System;
using System.Collections.Generic;

namespace EntityFrameworkL5.Models;

public partial class Word : BaseEntity
{
    public string Header { get; set; } = null!;

    public string KeyWord { get; set; } = null!;

    public virtual ICollection<KeyLink> KeyLinks { get; set; } = new List<KeyLink>();
}
