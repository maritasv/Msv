using System;
using System.Collections.Generic;
using System.Text;

namespace HINVenture.Shared.Models
{
    public class OrderProgress
    {
        public int Id { get; set; }
        public virtual Order Order { get; set; }
        public int ReadyLine { get; set; }
        public virtual FreelancerUser Freelancer { get; set; }
        public DateTime Month { get; set; }
    }
}
