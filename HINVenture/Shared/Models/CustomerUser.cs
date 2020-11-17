using System;
using System.Collections.Generic;
using System.Text;

namespace HINVenture.Shared.Models
{
	public class CustomerUser : ApplicationUser
    {
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
