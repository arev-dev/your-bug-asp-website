using ProjectPosts.EN;

namespace ProjectPosts.DAL;
public interface IPostRepository
{
    Task<bool>INSERT(Post modelo);
    Task<bool>UPDATE(Post modelo);
    Task<bool>DELETE(int ID);
    Task<Post>GET(int ID);
    Task<IQueryable<Post>>GET_ALL();
    IEnumerable<PostCommentsDTO> GetComments(int ID);
    IEnumerable<PostLikesDTO> GetLikes(int ID);
    IEnumerable<PostAllDTO> GetAllPosts();

}
