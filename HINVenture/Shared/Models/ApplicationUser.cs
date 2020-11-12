using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace HINVenture.Shared.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string CryptocoinAddress { get; set; }

        public ICollection<UserRoles> Roles { get; set; }
        
    }    
}

