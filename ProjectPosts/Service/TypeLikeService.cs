
using ProjectPosts.EN;

namespace ProjectPosts.BLL;
public class TypeLikeService : IGenericService<TypeLike>
{
    private readonly IGenericService<TypeLike> _context;

    public TypeLikeService(IGenericService<TypeLike> c)
    {
        _context = c;
    }
    public async Task<bool> DELETE(int ID)
    {
        return await _context.DELETE(ID);
    }

    public async Task<TypeLike> GET(int ID)
    {
        return await _context.GET(ID);
    }

    public async Task<IQueryable<TypeLike>> GET_ALL()
    {
        return await _context.GET_ALL();
    }

    public async Task<bool> INSERT(TypeLike modelo)
    {
        return await _context.INSERT(modelo);
    }

    public async Task<bool> UPDATE(TypeLike modelo)
    {
        return await _context.UPDATE(modelo);
    }
}
