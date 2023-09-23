using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjectPosts.DAL.DataContext;
using ProjectPosts.EN;
using ProjectPosts.EN.DTO;

namespace ProjectPosts.DAL.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly DbforoContext _dbContext;

        public CommentRepository(DbforoContext context)
        {
            _dbContext = context;
        }
        public async Task<bool> DELETE(int ID)
        {
            Comment c = _dbContext.Comments.First(c => c.Id == ID);
            _dbContext.Remove(c);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Comment> GET(int ID)
        {
            return await _dbContext.Comments.FindAsync(ID);
        }

        public async Task<IQueryable<Comment>> GET_ALL()
        {
            IQueryable<Comment> query = _dbContext.Comments;
            return query;
        }

        public async Task<bool> INSERT(Comment modelo)
        {
            _dbContext.Comments.Add(modelo);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UPDATE(Comment modelo)
        {
            _dbContext.Comments.Update(modelo);

            await _dbContext.SaveChangesAsync();
            

            return true;
        }  

        public IEnumerable<CommentReplyDTO> GetReplies(int ID)
        {
            var results = _dbContext.Set<CommentReplyDTO>()
                .FromSqlRaw("EXEC SPGetCommentReplies @ParentCommentId", new SqlParameter("@ParentCommentId", ID))
                .ToList();

            return results;
        }

        public IEnumerable<CommentLikesDTO> GetLikes(int ID)
        {
            var results = _dbContext.Set<CommentLikesDTO>()
                .FromSqlRaw("EXEC SPGetCommentLikes @IdComment", new SqlParameter("@IdComment", ID))
                .ToList();

            return results;
        }
    }
}