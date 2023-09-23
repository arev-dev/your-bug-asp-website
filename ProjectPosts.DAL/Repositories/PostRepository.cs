using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjectPosts.DAL.DataContext;
using ProjectPosts.EN;

namespace ProjectPosts.DAL.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly DbforoContext _dbContext;

        public PostRepository(DbforoContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> DELETE(int ID)
        {
            Post c = _dbContext.Posts.First(c => c.Id == ID);
            _dbContext.Remove(c);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Post> GET(int ID)
        {
            return await _dbContext.Posts.FindAsync(ID);
        }

        public IEnumerable<PostAllDTO> GetAllPosts()
        {
            var posts = _dbContext.Set<PostAllDTO>()
                .FromSqlRaw("EXEC SPGetALlPost")
                .ToList();

            // foreach (var post in posts)
            // {
            //     post.CommentsCount = _dbContext.Comments
            //         .Count(c => c.IdPost == post.PostId);

            //     posts.LikesCount = _dbContext.Likes
            //         .Count(l => l.IdPost == post.PostId);
            // }

            return posts;

        }

        public IEnumerable<PostCommentsDTO> GetComments(int ID)
        {
            var results = _dbContext.Set<PostCommentsDTO>()
                .FromSqlRaw("EXEC SPGetPostComments @IdPost", new SqlParameter("@IdPost", ID))
                .ToList();

            return results;
        }

        public IEnumerable<PostLikesDTO> GetLikes(int ID)
        {
            var results = _dbContext.Set<PostLikesDTO>()
                .FromSqlRaw("EXEC SPGetPostComments @IdPost", new SqlParameter("@IdPost", ID))
                .ToList();

            return results;
        }

        public async Task<IQueryable<Post>> GET_ALL()
        {
            IQueryable<Post> query = _dbContext.Posts;
            return query;
        }

        public async Task<bool> INSERT(Post modelo)
        {
            _dbContext.Posts.Add(modelo);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UPDATE(Post modelo)
        {
            _dbContext.Posts.Update(modelo);

            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}