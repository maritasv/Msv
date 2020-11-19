using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HINVenture.Shared.Models.Entities
{
    public class ApplicationRole : IdentityRole
    {
        public virtual ICollection<UserRoles> Users { get; set; }
    }
}
