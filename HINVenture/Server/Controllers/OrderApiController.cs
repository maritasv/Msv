using System.Collections.Generic;
using System.Linq;
using HINVenture.Shared.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HINVenture.Shared.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HINVenture.Shared.Models.Entities;

namespace HINVenture.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderApiController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private IRepository<Order> repository;

        public OrderApiController(IRepository<Order> repository)
        {
            this.repository = repository;
        }

        // GET: api/ProductAPI
        [HttpGet]
        [Route("{action}/{userName}")]
        public IEnumerable<Order> GetOrdersByCustomer(string userName)
        {
            return repository.GetAll().Where(a=>a.Customer.UserName == userName);
        }

        //// GET: api/Product/5
        //[HttpGet("{id}")]
        //public IActionResult Get([FromRoute] int id)
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
        //    return Ok(product);
        //}

        //// PUT: api/ProductAPI/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put([FromRoute] int id, [FromBody] ProductEditViewModel product)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != product.ProductId)
        //    {
        //        return BadRequest();
        //    }

        //    try
        //    {
        //        await repository.Update(product);
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ProductExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

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