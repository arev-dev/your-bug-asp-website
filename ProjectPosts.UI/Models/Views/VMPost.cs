using ProjectPosts.EN;

namespace ProjectPosts.UI;
public class VMPost
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public string? CreatedAt { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdStatus { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual StatusPost? IdStatusNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }

    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
