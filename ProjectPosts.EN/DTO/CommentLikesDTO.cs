using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPosts.EN.DTO
{
    public class CommentLikesDTO
    {
       public int? PostId { get; set; }
       public int? ParentCommentId { get; set; }
       public int? UserId { get; set; }
       public string? UserName { get; set; }
       public int? TypeLike { get; set; }
       
    }
}
