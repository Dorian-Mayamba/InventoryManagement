
namespace InventoryManagement.Data.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly ApplicationDBContext _context;
        public CustomerRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Customer e)
        {
            _context.customers.Add(e);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var customer = await _context.customers.FindAsync(id);
            if (customer == null)
            {
                throw new Exception("customer not found");
            }
            _context.customers.Remove(customer);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(Customer e)
        {
            _context.Entry(e).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAsync()
        {
            return await _context.customers
            .Include(c=>c.Orders)
            .ToListAsync();
        }

        public async Task<Customer> GetAsync(int id)
        {
            var customer = await _context.customers
            .Include(c=>c.Orders)
            .FirstAsync(c=>c.Id == id);
            if(customer == null)
            {
                throw new Exception("customer not found");
            }
            return customer;
        }
    }
}