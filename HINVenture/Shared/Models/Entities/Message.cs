using System;
using System.Collections.Generic;
using System.Text;

namespace HINVenture.Shared.Models.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public virtual Order Order { get; set; }
        public virtual CustomerUser Customer { get; set; }
        public virtual FreelancerUser Freelancer { get; set; }
        public DateTime PostedDate { get; set; }
        public string Text { get; set; }
	}
}
