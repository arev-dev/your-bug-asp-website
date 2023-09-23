using ProjectPosts.EN;

namespace ProjectPosts.BLL;
public class LikeService : ILikeService
{
    private readonly ILikeService _context;

    public LikeService(ILikeService c)
    {
        _context = c;
    }
    public async Task<bool> DELETE(int ID)
    {
        return await _context.DELETE(ID);
    }

    public async Task<Like> GET(int ID)
    {
        return await _context.GET(ID);
    }

    public async Task<IQueryable<Like>> GET_ALL()
    {
        return await _context.GET_ALL();
    }

    public async Task<bool> INSERT(Like modelo)
    {
        return await _context.INSERT(modelo);
    }

    public async Task<bool> UPDATE(Like modelo)
    {
        return await _context.UPDATE(modelo);
    }
}
