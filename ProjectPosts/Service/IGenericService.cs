namespace ProjectPosts.BLL;
public interface IGenericService<T> where T: class
{
    Task<bool>INSERT(T modelo);
        Task<bool>UPDATE(T modelo);
        Task<bool>DELETE(int ID);
        Task<T>GET(int ID);
        Task<IQueryable<T>>GET_ALL();
}
