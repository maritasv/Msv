using System;
using System.Collections.Generic;
using System.Text;

namespace HINVenture.Shared.Models
{
    public class Speciality
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ApplicationUser> Freelancers { get; set; }
    }
}
