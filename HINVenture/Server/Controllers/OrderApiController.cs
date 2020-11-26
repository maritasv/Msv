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
        private UserManager<ApplicationUser> _userManager;

        public OrderApiController(IRepository<Order> repository, UserManager<ApplicationUser> userManager )
        {
            this.repository = repository;
            _userManager = userManager;
        }

        // GET: api/ProductAPI
        [HttpGet]
        [Route("{action}/{userName}")]
        [Authorize]
        public IEnumerable<Order> GetOrdersByCustomer(string userName)
        {
            return repository.GetAll().Include(a=>a.Customer).ThenInclude(a=>a.ApplicationUser).Where(a=>a.Customer.ApplicationUser.UserName == userName);
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

            await repository.Create(order);
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
        public async Task<IActionResult> GetOrdersByid([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var order = await repository.Get(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        // PUT: api/ProductAPI/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [Bind("Id,Title,Description")] Order order)
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