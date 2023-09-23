
using ProjectPosts.EN;

namespace ProjectPosts.BLL;
public class StatusPostService : IGenericService<StatusPost>
{
    private readonly IGenericService<StatusPost> _context;

    public StatusPostService(IGenericService<StatusPost> c)
    {
        _context = c;
    }
    public async Task<bool> DELETE(int ID)
    {
        return await _context.DELETE(ID);
    }

    public async Task<StatusPost> GET(int ID)
    {
        return await _context.GET(ID);
    }

    public async Task<IQueryable<StatusPost>> GET_ALL()
    {
        return await _context.GET_ALL();
    }

    public async Task<bool> INSERT(StatusPost modelo)
    {
        return await _context.INSERT(modelo);
    }

    public async Task<bool> UPDATE(StatusPost modelo)
    {
        return await _context.UPDATE(modelo);
    }
}
