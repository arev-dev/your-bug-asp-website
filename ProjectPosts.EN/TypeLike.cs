using System;
using System.Collections.Generic;

namespace ProjectPosts.EN;

public partial class TypeLike
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();
}
