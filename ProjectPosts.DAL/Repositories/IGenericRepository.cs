using System;
using System.Threading.Tasks;

namespace ProjectPosts.DAL.Repositories
{
    public interface IGenericRepository<TMODELT> where TMODELT : class
    {
        Task<bool>INSERT(TMODELT modelo);
        Task<bool>UPDATE(TMODELT modelo);
        Task<bool>DELETE(int ID);
        Task<TMODELT>GET(int ID);
        Task<IQueryable<TMODELT>>GET_ALL();
    }
}