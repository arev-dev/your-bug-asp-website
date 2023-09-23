using System;
using System.Collections.Generic;

namespace ProjectPosts.EN;

public partial class Role
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
