
namespace InventoryManagement.Data.Repositories
{
    public class SaleRepository : IRepository<Sale>
    {
        private readonly ApplicationDBContext _context;

        public SaleRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Sale e)
        {
            _context.sales.Add(e);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var sale = await _context.sales.FindAsync(id);
            if(sale == null)
            {
                throw new Exception($"Sale with Sale id ${id} not found");
            }
            _context.sales.Remove(sale);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(Sale e)
        {
            _context.Entry(e).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Sale>> GetAsync()
        {
            return await _context.sales.ToListAsync();
        }

        public async Task<Sale> GetAsync(int id)
        {
            var sale = await _context.sales.FindAsync(id);
            if(sale == null)
            {
                throw new Exception($"Sale with Sale id ${id} not found");
            }
            return sale;
        }
    }
}