using HINVenture.Shared.Models;
using HINVenture.Shared.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HINVenture.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreelancersController : ControllerBase
    {
        protected IUserRepository<FreelancerUser> _freelancersRepository;
        public FreelancersController(IUserRepository<FreelancerUser> freelancersRepository)
        {
            _freelancersRepository = freelancersRepository;
        }

        [HttpGet]
        [Route("{action}")]
        [Authorize]
        public async Task<IEnumerable<FreelancerUser>> GetAllFreelancers()
        {
            return await _freelancersRepository.GetAll().Include(a => a.ApplicationUser).Include(a => a.Specs).ThenInclude(a => a.Speciality).ToListAsync();
        }

        [HttpGet]
        [Route("{action}/{specId}")]
        [Authorize]
        public async Task<IEnumerable<FreelancerUser>> GetFreelancersBySpec(int specId)
        {
            return await _freelancersRepository.GetAll().Where(a => a.Specs.Count(a => a.SpecialityId == specId) != 0)
                .Include(a => a.ApplicationUser).Include(a => a.Specs).ThenInclude(a => a.Speciality).ToListAsync();
        }       
    }
}
