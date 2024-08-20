
namespace InventoryManagement.Data.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private ApplicationDBContext _context;

        public CategoryRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Category e)
        {
            _context.categories.Add(e);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var category = await _context.categories.FindAsync(id);
            if(category == null)
            {
                throw new Exception("Category not found");
            }
            _context.categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(Category e)
        {
            _context.Entry(e).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetAsync()
        {
            var categories = await _context.categories.ToListAsync();
            return categories;
        }

        public async Task<Category> GetAsync(int id)
        {
            var category = await _context.categories.FindAsync(id);
            if(category == null)
            {
                throw new Exception("Not found");
            }
            return category;
        }
    }
}