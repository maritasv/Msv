﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Storage;

namespace HINVenture.Shared.Models.Entities
{
	public class CustomerUser
    {
        public string Id { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
