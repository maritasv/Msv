using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HINVenture.Shared.Models
{
    public class Order
    {
        public int Id { get; set; }

        [DisplayName("Created")]
        public DateTime PostedDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual CustomerUser Customer { get; set; }
        public virtual FreelancerUser CurrentFreelancer { get; set; }
        public virtual ICollection<Speciality> Specs { get; set; }
        public virtual ICollection<OrderProgress> OrderProgreses { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
