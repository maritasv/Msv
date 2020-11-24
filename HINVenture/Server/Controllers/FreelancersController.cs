using HINVenture.Shared.Models;
using HINVenture.Shared.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HINVenture.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreelancersController : ControllerBase
    {
        protected IRepository<FreelancerUser> _freelancersRepository;
        public FreelancersController(IRepository<FreelancerUser> freelancersRepository)
        {
            _freelancersRepository = freelancersRepository;
        }

        [HttpGet]
        [Route("{action}")]
        [Authorize]
        public async Task<IEnumerable<FreelancerUser>> GetAllFreelancers()
        {
            return await _freelancersRepository.GetAll().Include(a=>a.ApplicationUser).Include(a=>a.Specs).ThenInclude(a=>a.Speciality).ToListAsync();
        }

    }
}
