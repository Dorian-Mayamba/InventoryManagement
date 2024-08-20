
namespace InventoryManagement.Data.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private ApplicationDBContext _context;

        public OrderRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Order e)
        {
            _context.orders.Add(e);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var order = await _context.orders.FindAsync(id);
            if(order == null)
            {
                throw new Exception("Order not found");
            }
            _context.orders.Remove(order);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(Order e)
        {
            _context.Entry(e).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Order>> GetAsync()
        {
            return await _context.orders.ToListAsync();
        }

        public async Task<Order> GetAsync(int id)
        {
            var order = await _context.orders.FindAsync(id);
            if(order == null)
            {
                throw new Exception("Order not found");
            }
            return order;
        }
    }
}