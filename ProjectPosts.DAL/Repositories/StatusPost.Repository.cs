using ProjectPosts.DAL.DataContext;
using ProjectPosts.EN;

namespace ProjectPosts.DAL.Repositories
{
    public class StatusPostRepository : IGenericRepository<StatusPost>
    {
        private readonly DbforoContext _dbContext;

        public async Task<bool> DELETE(int ID)
        {
            StatusPost c = _dbContext.StatusPosts.First(c => c.Id == ID);
            _dbContext.Remove(c);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<StatusPost> GET(int ID)
        {
            return await _dbContext.StatusPosts.FindAsync(ID);
        }

        public async Task<IQueryable<StatusPost>> GET_ALL()
        {
            IQueryable<StatusPost> query = _dbContext.StatusPosts;
            return query;
        }

        public async Task<bool> INSERT(StatusPost modelo)
        {
            _dbContext.StatusPosts.Add(modelo);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UPDATE(StatusPost modelo)
        {
            _dbContext.StatusPosts.Update(modelo);

            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}