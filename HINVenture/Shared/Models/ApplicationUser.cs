using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HINVenture.Shared.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string CryptocoinAddress { get; set; }
        public ICollection<UserRoles> Roles { get; set; }                
    }    
}
