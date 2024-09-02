namespace InventoryManagement.Data.Repositories
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAsync(); 
        Task<T> GetAsync(int id);
        Task AddAsync(T e);
        Task EditAsync(T e);
        Task DeleteAsync(int id);
    }
}