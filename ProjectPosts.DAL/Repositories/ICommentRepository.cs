using ProjectPosts.EN;
using ProjectPosts.EN.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPosts.DAL.Repositories
{
    public interface ICommentRepository
    {
        Task<bool> INSERT(Comment modelo);
        Task<bool> UPDATE(Comment modelo);
        Task<bool> DELETE(int ID);
        Task<Comment> GET(int ID);
        Task<IQueryable<Comment>> GET_ALL();
        IEnumerable<CommentReplyDTO> GetReplies(int ID);
        IEnumerable<CommentLikesDTO> GetLikes(int ID);


    }
}
