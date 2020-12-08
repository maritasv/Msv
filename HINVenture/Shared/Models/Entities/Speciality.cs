using System;
using System.Collections.Generic;
using System.Text;

namespace HINVenture.Shared.Models.Entities
{
    public class Speciality
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<FreelancerUser> Freelancers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
