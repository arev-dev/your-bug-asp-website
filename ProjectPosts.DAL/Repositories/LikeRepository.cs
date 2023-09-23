using ProjectPosts.DAL.DataContext;
using ProjectPosts.EN;

namespace ProjectPosts.DAL.Repositories
{
    public class LikeRepository : IGenericRepository<Like>
    {

        private readonly DbforoContext _dbContext;

        public async Task<bool> DELETE(int ID)
        {
            Like c = _dbContext.Likes.First(c => c.Id == ID);
            _dbContext.Remove(c);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Like> GET(int ID)
        {
            return await _dbContext.Likes.FindAsync(ID);
        }

        public async Task<IQueryable<Like>> GET_ALL()
        {
            IQueryable<Like> query = _dbContext.Likes;
            return query;
        }

        public async Task<bool> INSERT(Like modelo)
        {
            _dbContext.Likes.Add(modelo);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UPDATE(Like modelo)
        {
            _dbContext.Likes.Update(modelo);

            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}