using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace HINVenture.Shared.Models
{
    public class ApplicationRole : IdentityRole
    {
        public virtual ICollection<UserRoles> Users { get; set; }
    }
}