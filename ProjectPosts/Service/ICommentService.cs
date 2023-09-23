using ProjectPosts.EN;
using ProjectPosts.EN.DTO;

namespace ProjectPosts.BLL.Service;

public interface ICommentService 
{
    Task<bool>INSERT(Comment modelo);
    Task<bool>UPDATE(Comment modelo);
    Task<bool>DELETE(int ID);
    Task<Comment>GET(int ID);
    Task<IQueryable<Comment>>GET_ALL();
    IEnumerable<CommentReplyDTO> GetReplies(int ID);
    IEnumerable<CommentLikesDTO> GetLikes(int ID);

} 
