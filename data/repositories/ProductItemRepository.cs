

namespace InventoryManagement.Data.Repositories
{
    public class ProductItemRepository : IRepository<ProductItem>
    {
        private readonly ApplicationDBContext _context;

        public ProductItemRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(ProductItem e)
        {
            _context.productItems.Add(e);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var itemToDelete = await GetAsync(id);

            if (itemToDelete == null)
            {
                throw new Exception($"item with id {id} not found");
            }
            _context.productItems.Remove(itemToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(ProductItem e)
        {
            _context.Entry(e).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductItem>> GetAsync()
        {
            return await _context.productItems.
            Include(pI => pI.Variation).
            ThenInclude(v => v.Category).
            Include(pI => pI.Variation).
            ThenInclude(v => v.Size).
            Include(pI => pI.Product)
            .ThenInclude(p => p.Inventory)
            .ToListAsync();
        }

        public async Task<ProductItem> GetAsync(int id)
        {
            var item = await _context.productItems.
            Include(pI => pI.Variation).
            ThenInclude(v => v.Category).
            Include(pI => pI.Variation).
            ThenInclude(v => v.Size).
            Include(pI => pI.Product)
            .ThenInclude(p => p.Inventory)
            .FirstAsync(pI => pI.Id == id);
            if (item == null)
            {
                throw new Exception($"item with id {id} not found");
            }
            return item;
        }
    }
}