using System;
using System.Collections.Generic;

namespace ProjectPosts.EN;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Code { get; set; }

    public int? IdRole { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual Role? IdRoleNavigation { get; set; }

    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
