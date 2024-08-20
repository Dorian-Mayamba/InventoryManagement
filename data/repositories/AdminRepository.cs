
using Microsoft.AspNetCore.Http.HttpResults;

namespace InventoryManagement.Data.Repositories
{
    public class AdminRepository : IRepository<Admin>
    {

        private readonly ApplicationDBContext _context;

        public AdminRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Admin e)
        {
            _context.admins.Add(e);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var admin = await _context.admins.FindAsync(id);
            if(admin == null)
            {
                throw new Exception("admin not found");
            }
            _context.admins.Remove(admin);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(Admin e)
        {
            _context.Entry(e).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Admin>> GetAsync()
        {
            var admins = await _context.admins.ToListAsync();
            return admins;
        }

        public async Task<Admin> GetAsync(int id)
        {
            var admin = await _context.admins.FindAsync(id);
            if(admin == null)
            {
                throw new Exception("admin not found");
            }
            return admin;
        }
    }
}