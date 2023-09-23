using ProjectPosts.DAL.DataContext;
using ProjectPosts.EN;

namespace ProjectPosts.DAL.Repositories
{
    public class TypeLikeRepository : IGenericRepository<TypeLike>
    {
        private readonly DbforoContext _dbContext;

        public async Task<bool> DELETE(int ID)
        {
            TypeLike c = _dbContext.TypeLikes.First(c => c.Id == ID);
            _dbContext.Remove(c);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<TypeLike> GET(int ID)
        {
            return await _dbContext.TypeLikes.FindAsync(ID);
        }

        public async Task<IQueryable<TypeLike>> GET_ALL()
        {
            IQueryable<TypeLike> query = _dbContext.TypeLikes;
            return query;
        }

        public async Task<bool> INSERT(TypeLike modelo)
        {
            _dbContext.TypeLikes.Add(modelo);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UPDATE(TypeLike modelo)
        {
            _dbContext.TypeLikes.Update(modelo);

            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}