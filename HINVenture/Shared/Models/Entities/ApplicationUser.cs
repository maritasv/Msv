using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HINVenture.Shared.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string CryptocoinAddress { get; set; }
        public string FullName { get; set; }
        public ICollection<UserRoles> Roles { get; set; }        
        public CustomerUser CustomerUser { get; set; }
        public FreelancerUser FreelancerUser { get; set; }
    }    
}
