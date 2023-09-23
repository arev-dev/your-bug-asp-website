
using ProjectPosts.EN;

namespace ProjectPosts.BLL;
public class ReportService : IGenericService<Report>
{
    private readonly IGenericService<Report> _context;

    public ReportService(IGenericService<Report> c)
    {
        _context = c;
    }
    public async Task<bool> DELETE(int ID)
    {
        return await _context.DELETE(ID);
    }

    public async Task<Report> GET(int ID)
    {
        return await _context.GET(ID);
    }

    public async Task<IQueryable<Report>> GET_ALL()
    {
        return await _context.GET_ALL();
    }

    public async Task<bool> INSERT(Report modelo)
    {
        return await _context.INSERT(modelo);
    }

    public async Task<bool> UPDATE(Report modelo)
    {
        return await _context.UPDATE(modelo);
    }
}
