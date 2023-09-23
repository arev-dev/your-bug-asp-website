
using ProjectPosts.EN;

namespace ProjectPosts.BLL;
public class UsuarioService : IGenericService<Usuario>
{
    private readonly IGenericService<Usuario> _context;

    public UsuarioService(IGenericService<Usuario> c)
    {
        _context = c;
    }
    public async Task<bool> DELETE(int ID)
    {
        return await _context.DELETE(ID);
    }

    public async Task<Usuario> GET(int ID)
    {
        return await _context.GET(ID);
    }

    public async Task<IQueryable<Usuario>> GET_ALL()
    {
        return await _context.GET_ALL();
    }

    public async Task<bool> INSERT(Usuario modelo)
    {
        return await _context.INSERT(modelo);
    }

    public async Task<bool> UPDATE(Usuario modelo)
    {
        return await _context.UPDATE(modelo);
    }
}
