
namespace InventoryManagement.Data.Repositories
{
    public class PurchaseRepository : IRepository<Purchase>
    {
        private readonly ApplicationDBContext _context;

        public PurchaseRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Purchase e)
        {
            _context.purchases.Add(e);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var purchase = await _context.purchases.FindAsync(id);
            if(purchase == null)
            {
                throw new ArgumentException($"Purchase with Purchase id {id} not found");
            }
            _context.purchases.Remove(purchase);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(Purchase e)
        {
            _context.Entry(e).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Purchase>> GetAsync()
        {
            return await _context.purchases.ToListAsync();
        }

        public async Task<Purchase> GetAsync(int id)
        {
            var purchase = await _context.purchases.FindAsync(id);
            if(purchase == null)
            {
                throw new ArgumentException($"Purchase with Purchase id {id} not found");
            }
            return purchase;
        }
    }
}