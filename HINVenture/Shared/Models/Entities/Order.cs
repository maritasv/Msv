using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace HINVenture.Shared.Models.Entities
{
    public class Order
    {
        public int Id { get; set; }

        [DisplayName("Created")]
        public DateTime PostedDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public virtual CustomerUser Customer { get; set; }
        public virtual FreelancerUser CurrentFreelancer { get; set; }
        public int SpecialityId { get; set; }
        public virtual Speciality Speciality { get; set; }
        public virtual ICollection<OrderProgress> OrderProgresses { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public int Rate { get; set; }
    }
}
