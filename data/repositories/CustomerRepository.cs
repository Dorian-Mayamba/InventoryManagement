
namespace InventoryManagement.Data.Repositories
{
    public class CustomerRepository : IUserRepository<Customer>
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
        public async Task DeleteAsync(string id)
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

        public async Task<Customer> FindByEmail(string email)
        {
            var customer = await _context.customers
            .Include(c=>c.Orders)
            .FirstOrDefaultAsync(c=>c.Email == email) ?? throw new Exception("Customer not found");
            return customer;
        }

        public async Task<IEnumerable<Customer>> GetAsync()
        {
            return await _context.customers
            .Include(c=>c.Orders)
            .ToListAsync();
        }
        public async Task<Customer> GetAsync(string id)
        {
            var customer = await _context.customers
            .Include(c=>c.Orders)
            .FirstAsync(c=>c.Id.Equals(id));
            if(customer == null)
            {
                throw new Exception("customer not found");
            }
            return customer;
        }
    }
}