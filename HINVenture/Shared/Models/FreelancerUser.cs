using System;
using System.Collections.Generic;
using System.Text;

namespace HINVenture.Shared.Models
{

    public class FreelancerUser : ApplicationUser
    {
        public virtual ICollection<Order> CurrentOrders { get; set; }
        public virtual ICollection<OrderProgress> OrderProgresses { get; set; }
        public virtual ICollection<Speciality> Specs { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public decimal Price { get; set; }
        public float Rate { get; set; }
    }
}
