using ProjectPosts.DAL.DataContext;
using ProjectPosts.EN;

namespace ProjectPosts.DAL.Repositories
{
    public class RoleRepository : IGenericRepository<Role>
    {
        private readonly DbforoContext _dbContext;

        public async Task<bool> DELETE(int ID)
        {
            Role c = _dbContext.Roles.First(c => c.Id == ID);
            _dbContext.Remove(c);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Role> GET(int ID)
        {
            return await _dbContext.Roles.FindAsync(ID);
        }

        public async Task<IQueryable<Role>> GET_ALL()
        {
            IQueryable<Role> query = _dbContext.Roles;
            return query;
        }

        public async Task<bool> INSERT(Role modelo)
        {
            _dbContext.Roles.Add(modelo);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UPDATE(Role modelo)
        {
            _dbContext.Roles.Update(modelo);

            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}