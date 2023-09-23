
using ProjectPosts.EN;

namespace ProjectPosts.BLL;
public class RoleService : IGenericService<Role>
{
    private readonly IGenericService<Role> _context;

    public RoleService(IGenericService<Role> c)
    {
        _context = c;
    }
    public async Task<bool> DELETE(int ID)
    {
        return await _context.DELETE(ID);
    }

    public async Task<Role> GET(int ID)
    {
        return await _context.GET(ID);
    }

    public async Task<IQueryable<Role>> GET_ALL()
    {
        return await _context.GET_ALL();
    }

    public async Task<bool> INSERT(Role modelo)
    {
        return await _context.INSERT(modelo);
    }

    public async Task<bool> UPDATE(Role modelo)
    {
        return await _context.UPDATE(modelo);
    }
}
