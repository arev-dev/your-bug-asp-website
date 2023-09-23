using ProjectPosts.DAL;
using ProjectPosts.EN;

namespace ProjectPosts.BLL;
public class PostService : IPostService
{
    private readonly IPostRepository _context;

    public PostService(IPostRepository context)
    {
        _context = context;
    }
    public async Task<bool> DELETE(int ID)
    {
        return await _context.DELETE(ID);
    }

    public async Task<Post> GET(int ID)
    {
        return await _context.GET(ID);
    }

    public IEnumerable<PostAllDTO> GetAllPosts()
    {
        return _context.GetAllPosts();
    }

    public IEnumerable<PostCommentsDTO> GetComments(int ID)
    {
        return _context.GetComments(ID);
    }

    public IEnumerable<PostLikesDTO> GetLikes(int ID)
    {
       return _context.GetLikes(ID);
    }

    public async Task<IQueryable<Post>> GET_ALL()
    {
        return await _context.GET_ALL();
    }

    public async Task<bool> INSERT(Post modelo)
    {
        return await _context.INSERT(modelo);
    }

    public async Task<bool> UPDATE(Post modelo)
    {
        return await _context.UPDATE(modelo);
    }
}
