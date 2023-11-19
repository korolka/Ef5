using System;
using System.Collections.Generic;

namespace EntityFrameworkL5.Models;

public partial class Category : BaseEntity
{
    public string Name { get; set; } = null!;

    public string Icon { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
