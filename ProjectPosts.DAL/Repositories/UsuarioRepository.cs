using ProjectPosts.DAL.DataContext;
using ProjectPosts.EN;

namespace ProjectPosts.DAL.Repositories
{
    public class UsuarioRepository : IGenericRepository<Usuario>
    {
        private readonly DbforoContext _dbContext;

        public async Task<bool> DELETE(int ID)
        {
            Usuario c = _dbContext.Usuarios.First(c => c.Id == ID);
            _dbContext.Remove(c);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Usuario> GET(int ID)
        {
            return await _dbContext.Usuarios.FindAsync(ID);
        }

        public async Task<IQueryable<Usuario>> GET_ALL()
        {
            IQueryable<Usuario> query = _dbContext.Usuarios;
            return query;
        }

        public async Task<bool> INSERT(Usuario modelo)
        {
            _dbContext.Usuarios.Add(modelo);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UPDATE(Usuario modelo)
        {
            _dbContext.Usuarios.Update(modelo);

            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}