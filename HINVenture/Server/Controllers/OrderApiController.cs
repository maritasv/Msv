using System.Collections.Generic;
using System.Linq;
using HINVenture.Shared.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HINVenture.Shared.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HINVenture.Shared.Models.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using Microsoft.AspNetCore.Authorization;

namespace HINVenture.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderApiController : ControllerBase
    {
        private IRepository<Order> repository;
        private IRepository<Speciality> _specRepository;
        private UserManager<ApplicationUser> _userManager;
        private IUserRepository<FreelancerUser> _freelancerRepository;

        public OrderApiController(IRepository<Order> repository, IRepository<Speciality> specRepository, UserManager<ApplicationUser> userManager, IUserRepository<FreelancerUser> freelancerRepository)
        {
            this.repository = repository;
            _userManager = userManager;
            _specRepository = specRepository;
            _freelancerRepository = freelancerRepository;
        }

        // GET: api/ProductAPI
        [HttpGet]
        [Route("{action}/{userName}")]
        [Authorize]
        public IEnumerable<Order> GetOrdersByCustomer(string userName)
        {
            var result = repository.GetAll()
                .Include(a => a.Customer)
                .ThenInclude(a => a.ApplicationUser)
                .Include(a=>a.Speciality)
                .Where(a => a.Customer.ApplicationUser.UserName == userName);
            return result;
        }


        // GET: api/ProductAPI
        [HttpPost]
        [Route("{action}/{userName}")]
        [Authorize]
        public IEnumerable<Order> AcceptOrder(Order order, string userName)
        {
            var result = repository.GetAll()
                .Include(a => a.Customer)
                .ThenInclude(a => a.ApplicationUser)
                .Include(a => a.Speciality)
                .Where(a => a.Customer.ApplicationUser.UserName == userName);
            return result;
        }

        // GET: api/ProductAPI
        [HttpGet]
        [Route("{action}/{userName}")]
        [Authorize]
        public IEnumerable<Order> GetNewOrdersAvailableForFreelancer(string userName)
        {
            var result = repository.GetAll()
                .Include(a => a.Customer)
                .ThenInclude(a => a.ApplicationUser)
                .Include(a=>a.Speciality)
                .Where(a => a.CurrentFreelancer == null);

            FreelancerUser user =_freelancerRepository.GetAll().Include(a=>a.ApplicationUser)
                .Include(a=>a.Specs)
                .FirstOrDefault(a => a.ApplicationUser.UserName == userName);

            List<Order> resultOrders = new List<Order>();
            foreach (var order in  result)
            {
                if (user.Specs.FirstOrDefault(a => a.SpecialityId == order.SpecialityId) != null)
                {
                    resultOrders.Add(order);
                }
            }
            return resultOrders;
        }



        // POST: api/ProductAPI
        [HttpPost("{userName}")]
        [Authorize(Roles = "customer")]
        
        public async Task<IActionResult> Post([FromBody] Order order, string userName)
        {
            var user = await _userManager.Users.Include(a=>a.CustomerUser).FirstOrDefaultAsync(a=>a.UserName == userName);
            if (user == null)
                return BadRequest(ModelState);
            
            order.Customer = user.CustomerUser;
            order.PostedDate = DateTime.Now;
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {

                await repository.Create(order);
            }
            catch (Exception ex)
            {

            }

            return Ok();
        }

        // GET: api/ProductAPI
        [HttpGet]
        [Route("{action}/{userName}")]
        [Authorize]
        public IEnumerable<Order> GetOrdersByFreelancer(string userName)
        {
            return repository.GetAll().Include(a => a.CurrentFreelancer).ThenInclude(a => a.ApplicationUser).Where(a => a.CurrentFreelancer.ApplicationUser.UserName == userName);
        }


        // GET: api/Product/5
        [HttpGet("{id}")]
        [Authorize]
        [Route("{action}/{id}")]
        public async Task<IActionResult> GetOrdersByid([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var order = await repository.GetAll().Include(a => a.CurrentFreelancer).
                ThenInclude(a => a.ApplicationUser).Include(a => a.Speciality).FirstOrDefaultAsync(a => a.Id == id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpGet]
        [Route("{action}/{orderId}/{username}")]
        public async Task<IActionResult> AssignOrderToFreelancer(int orderId, string username)
        {
            var order = await repository.Get(orderId);
            order.CurrentFreelancer = _freelancerRepository.GetAll()
                .Include(a => a.ApplicationUser)
                .FirstOrDefault(a => a.ApplicationUser.UserName == username);
            await repository.Update(order);
            
            return Ok();
        }



        // PUT: api/ProductAPI/5
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != order.Id)
            {
                return BadRequest();
            }

            try
            {
                await repository.Update(order);
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return NoContent();
        }

        //// POST: api/ProductAPI
        //[HttpPost]
        ////        public async Task<IActionResult> Post(Product product)
        //public async Task<IActionResult> Post([FromBody] Product product)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    //await repository.add(product, User);
        //    repository.Save(product);

        //    return CreatedAtAction("GetProduct", new { id = product.ProductId }, product);
        //}

        //// DELETE: api/ProductAPI/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var product = repository.Get(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    repository.Remove(product);

        //    return Ok(product);
        //}

        //private bool ProductExists(int id)
        //{
        //    return context.Products.Any(e => e.ProductId == id);
        //}

    }
}