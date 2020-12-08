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
        protected IRepository<Speciality> _specialitiesRepository;
        public FreelancersController(IUserRepository<FreelancerUser> freelancersRepository,
            IRepository<Speciality> specialitiesRepository
            )
        {
            _specialitiesRepository = specialitiesRepository;
            _freelancersRepository = freelancersRepository;
        }

        [HttpGet]
        [Route("{action}")]
        [Authorize]
        public async Task<IEnumerable<FreelancerUser>> GetAllFreelancers()
        {
            return await _freelancersRepository.GetAll().Include(a => a.ApplicationUser).Include(a => a.Specs).ToListAsync();
        }

        [HttpGet]
        [Route("{action}/{specId}")]
        [Authorize]
        public async Task<IEnumerable<FreelancerUser>> GetFreelancersBySpec(int specId)
        {
            return await _freelancersRepository.GetAll().Where(a => a.Specs.Id == specId)
                .Include(a => a.ApplicationUser).Include(a => a.Specs).ToListAsync();
        }

        // GET: api/Product/5
        [HttpGet]
        [Route("{action}/{userName}")]
        [Authorize]
        public async Task<IActionResult> GetFreelancerByid([FromRoute] string userName)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = await _freelancersRepository.GetAll().
                Include(a => a.ApplicationUser).
             //   Include(a => a.Specs).
                FirstOrDefaultAsync(a => a.ApplicationUser.UserName == userName);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // PUT: api/ProductAPI/5
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Put([FromRoute] string id, [FromBody] FreelancerUser user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.Id)
            {
                return BadRequest();
            }

            try
            {
                user.Specs = await _specialitiesRepository.Get(user.Specs.Id);
                await _freelancersRepository.Update(user);
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
