using System;
using System.Collections.Generic;
using System.Text;

namespace HINVenture.Shared.Models.Entities
{
    public class FreelancerSpeciality
    {
        public string FreelancerUserId { get; set; }
        public virtual FreelancerUser FreelancerUser { get; set; }
        public int SpecialityId { get; set; }
        public virtual Speciality Speciality { get; set; }
    }
}
