using Microsoft.AspNetCore.Identity;

namespace InventoryManagement.Models
{
    public abstract class User: IdentityUser{
        public int RoleId {get; set;}
        public Role Role {get; set;} = null!;
    }
}