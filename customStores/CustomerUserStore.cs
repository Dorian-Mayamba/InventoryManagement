using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace InventoryManagement.CustomStores
{
    public class CustomUserStore : IUserStore<Customer>, IUserPasswordStore<Customer>, IUserEmailStore<Customer>
    {
        private readonly ApplicationDBContext _context;

        public CustomUserStore(ApplicationDBContext ctx)
        {
            _context = ctx;
        }

        public async Task<IdentityResult> CreateAsync(Customer user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            user.RoleId = 2;

            await _context.customers.AddAsync(user);
            await _context.SaveChangesAsync(cancellationToken);
            return IdentityResult.Success;
        }

        public async Task<IdentityResult> DeleteAsync(Customer user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            _context.customers.Remove(user);
            await _context.SaveChangesAsync(cancellationToken);
            return IdentityResult.Success;
        }

        public void Dispose()
        {

        }

        public Task<Customer?> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer?> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var user = await _context.customers
                .Where(c=>c.Id == userId)
                .FirstOrDefaultAsync();
            return user;
        }

        public async Task<Customer?> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            var user = await _context.customers
                .Where(c=>c.UserName == normalizedUserName)
                .SingleOrDefaultAsync();
            return user;
        }

        public Task<string?> GetEmailAsync(Customer user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ArgumentNullException.ThrowIfNull(user);
            return Task.FromResult(user.Email);
        }

        public Task<bool> GetEmailConfirmedAsync(Customer user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ArgumentNullException.ThrowIfNull(user);
            return Task.FromResult(user.EmailConfirmed);
        }

        public Task<string?> GetNormalizedEmailAsync(Customer user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ArgumentNullException.ThrowIfNull(user);
            return Task.FromResult(user.NormalizedEmail);
        }

        public Task<string?> GetNormalizedUserNameAsync(Customer user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            return Task.FromResult(user.NormalizedUserName);
        }

        public Task<string?> GetPasswordHashAsync(Customer user, CancellationToken cancellationToken)
        {
             cancellationToken.ThrowIfCancellationRequested();
            ArgumentNullException.ThrowIfNull(user);
            return Task.FromResult(user.PasswordHash);
        }

        public Task<string> GetUserIdAsync(Customer user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            return Task.FromResult(user.Id);
        }

        public Task<string?> GetUserNameAsync(Customer user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            return Task.FromResult(user.UserName);
        }

        public Task<bool> HasPasswordAsync(Customer user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ArgumentNullException.ThrowIfNull(user);
            return Task.FromResult(user.PasswordHash != null);
        }

        public Task SetEmailAsync(Customer user, string? email, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if(user == null) throw new ArgumentNullException(nameof(user));
            if(email == null) throw new ArgumentNullException(nameof(email));
            user.Email = email;
            return Task.FromResult(user);
        }

        public Task SetEmailConfirmedAsync(Customer user, bool confirmed, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if(user == null) throw new ArgumentNullException(nameof(user));
            user.EmailConfirmed = confirmed;
            return Task.FromResult(user);
        }

        public Task SetNormalizedEmailAsync(Customer user, string? normalizedEmail, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ArgumentNullException.ThrowIfNull(user);
            ArgumentNullException.ThrowIfNull(normalizedEmail);
            user.NormalizedEmail = normalizedEmail;
            return Task.FromResult(user);
        }

        public Task SetNormalizedUserNameAsync(Customer user, string? normalizedName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if(user == null) throw new ArgumentNullException(nameof(user));
            if(normalizedName == null) throw new ArgumentNullException(nameof(normalizedName));

            user.NormalizedUserName = normalizedName;
            return Task.FromResult<object>(user);
        }

        public Task SetPasswordHashAsync(Customer user, string? passwordHash, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (passwordHash == null) throw new ArgumentNullException(nameof(passwordHash));
            user.PasswordHash = passwordHash;
            return Task.FromResult<object>(user);
        }

        public Task SetUserNameAsync(Customer user, string? userName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if(user == null) throw new ArgumentNullException(nameof(user));
            if(userName == null) throw new ArgumentNullException(nameof(userName));

            user.NormalizedUserName = userName;
            return Task.FromResult<object>(user);
        }

        public Task<IdentityResult> UpdateAsync(Customer user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }


}