
namespace InventoryManagement.Data.Repositories
{
    public class RoleRepository : IRepository<Role>
    {
        private readonly ApplicationDBContext _context;

        public RoleRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Role e)
        {
            _context.roles.Add(e);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var role = await _context.roles.FindAsync(id);
            if(role == null)
            {
                throw new Exception($"Role with role id {id} not found");
            }
            _context.roles.Remove(role);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(Role e)
        {
            _context.Entry(e).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Role>> GetAsync()
        {
            return await _context.roles.ToListAsync();
        }

        public async Task<Role> GetAsync(int id)
        {
            var role = await _context.roles.FindAsync(id);
            if(role == null)
            {
                throw new Exception($"Role with role id {id} not found");
            }
            return role;
        }
    }
}