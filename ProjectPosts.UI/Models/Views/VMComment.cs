using ProjectPosts.EN;

namespace ProjectPosts.UI.Models.Views;

public class VMComment
{
    public int Id { get; set; }

    public string? Content { get; set; }

    public string? CreatedAt { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdPost { get; set; }
 
    public int? IdParentComment { get; set; }

    public virtual Post? IdPostNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }

    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
