
namespace InventoryManagement.Data.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private ApplicationDBContext _context;

        public ProductRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Product e)
        {
            _context.products.Add(e);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _context.products.FindAsync(id);
            if(product == null)
            {
                throw new Exception($"Product with id {id} not found");
            }
            _context.products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(Product e)
        {
            _context.Entry(e).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAsync()
        {
            return await _context.products.
            Include(c=>c.Category)
            .Include(i=>i.Inventory)
            .ToListAsync();
        }

        public async Task<Product> GetAsync(int id)
        {
            var product = await _context.products
            .Include(c=>c.Category)
            .Include(i=>i.Inventory)
            .FirstAsync(p=>p.Id == id);
            if(product == null)
            {
                throw new Exception($"Product with id {id} not found");
            }
            return product;
        }
    }
}