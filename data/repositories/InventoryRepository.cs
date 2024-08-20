
namespace InventoryManagement.Data.Repositories
{
    public class InventoryRepository : IRepository<Inventory>
    {
        private ApplicationDBContext _context;

        public InventoryRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Inventory e)
        {
            _context.inventories.Add(e);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var inventory = await _context.inventories.FindAsync(id);
            if (inventory == null)
            {
                throw new Exception("Inventory not found");
            }
            _context.inventories.Remove(inventory);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(Inventory e)
        {
            _context.Entry(e).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Inventory>> GetAsync()
        {
            return await _context.inventories
                .DistinctBy(x=>x.ProductId)
                .Include(i=>i.Product)
                .ThenInclude(p=>p.Category)
                .ToListAsync();
        }

        public async Task<Inventory> GetAsync(int id)
        {
            var inventory = await _context.inventories
            .Include(i=>i.Product)
            .FirstAsync(i=>i.Id == id);
            if(inventory == null)
            {
                throw new Exception("Inventory not found");
            }
            return inventory;
        }
    }
}