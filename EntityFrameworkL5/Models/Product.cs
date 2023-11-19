using System;
using System.Collections.Generic;

namespace EntityFrameworkL5.Models;

public partial class Product : BaseEntity
{
    public string Name { get; set; } = null!;

    public double Price { get; set; }

    public double ActionPrice { get; set; }

    public string DescriptionField1 { get; set; } = null!;

    public string DescriptionField2 { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<KeyLink> KeyLinks { get; set; } = new List<KeyLink>();
}
