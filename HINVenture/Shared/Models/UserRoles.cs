using Microsoft.AspNetCore.Identity;

namespace HINVenture.Shared.Models
{
    public class UserRoles : IdentityUserRole<string>
    {
        public ApplicationUser User { get; set; }
        public ApplicationRole Role { get; set; }
    }
}