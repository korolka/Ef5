using System;
using System.Collections.Generic;

namespace EntityFrameworkL5.Models;

public partial class User : BaseEntity
{
    public string Name { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();
}
