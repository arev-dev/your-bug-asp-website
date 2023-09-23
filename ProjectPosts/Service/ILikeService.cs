using ProjectPosts.EN;

namespace ProjectPosts.BLL;
public interface ILikeService
{
    Task<bool>INSERT(Like modelo);
    Task<bool>UPDATE(Like modelo);
    Task<bool>DELETE(int ID);
    Task<Like>GET(int ID);
    Task<IQueryable<Like>>GET_ALL();
}
