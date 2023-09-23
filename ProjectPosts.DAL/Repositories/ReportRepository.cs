using ProjectPosts.DAL.DataContext;
using ProjectPosts.EN;

namespace ProjectPosts.DAL.Repositories
{
    public class ReportRepository : IGenericRepository<Report>
    {
       private readonly DbforoContext _dbContext;

        public async Task<bool> DELETE(int ID)
        {
            Report c = _dbContext.Reports.First(c => c.Id == ID);
            _dbContext.Remove(c);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Report> GET(int ID)
        {
            return await _dbContext.Reports.FindAsync(ID);
        }

        public async Task<IQueryable<Report>> GET_ALL()
        {
            IQueryable<Report> query = _dbContext.Reports;
            return query;
        }

        public async Task<bool> INSERT(Report modelo)
        {
            _dbContext.Reports.Add(modelo);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UPDATE(Report modelo)
        {
            _dbContext.Reports.Update(modelo);

            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}