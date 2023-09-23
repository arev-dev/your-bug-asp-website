using System;
using System.Collections.Generic;

namespace ProjectPosts.EN;

public partial class StatusPost
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
