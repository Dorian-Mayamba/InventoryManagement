namespace InventoryManagement.Data.Repositories
{
    public interface IUserRepository<T>:IRepository<T>
    {
        Task<T> GetAsync(string id);
        Task DeleteAsync(string id);
        Task<T> FindByEmail(string email);
    }
}