namespace InventoryManagement.Data.Repositories
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAsync(){
            throw new NotImplementedException();
        }  
        Task<T> GetAsync(int id){
            throw new NotImplementedException();
        }
        Task AddAsync(T e);
        Task EditAsync(T e);
        Task DeleteAsync(int id);
    }
}