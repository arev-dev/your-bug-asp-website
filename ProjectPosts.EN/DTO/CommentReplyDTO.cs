using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPosts.EN.DTO
{
    public class CommentReplyDTO
    {
        public int? CommentId { get; set; }
        public int? PostId { get; set; }
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        public string? CommentContent { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
