using System;
using System.Collections.Generic;

namespace ProjectPosts.EN;

public partial class Like
{
    public int Id { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdPost { get; set; }

    public int? IdComment { get; set; }

    public int? IdTypelike { get; set; }

    public virtual Comment? IdCommentNavigation { get; set; }

    public virtual Post? IdPostNavigation { get; set; }

    public virtual TypeLike? IdTypelikeNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
