using HINVenture.Shared.Models;
using HINVenture.Shared.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
    public class CommentsController : ControllerBase
    {
        private readonly IRepository<Message> _messageRepository;
        private readonly IRepository<Order> _orderRepository;
        private readonly IUserRepository<FreelancerUser> _freelancerRepository;
        private readonly IUserRepository<CustomerUser> _customerRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public CommentsController(IRepository<Message> repository, 
            IRepository<Order> orderRepository, 
            UserManager<ApplicationUser> userManager,
            IUserRepository<FreelancerUser> freelancerRepository,
            IUserRepository<CustomerUser> customerRepository
            )
        {
            _messageRepository = repository;
            _orderRepository = orderRepository;
            _userManager = userManager;
            _freelancerRepository = freelancerRepository;
            _customerRepository = customerRepository;

        }

        // GET: api/Product/5
        [HttpGet("{id}")]
        [Authorize]
        [Route("{action}/{id}")]
        public async Task<IActionResult> GetMessagesByOrder([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var messages = await _messageRepository.GetAll().Include(a => a.Freelancer).
                ThenInclude(a => a.ApplicationUser).Include(a=>a.Order).Where(a => a.Order.Id == id).OrderByDescending(a => a.PostedDate).ToListAsync();
            if (messages == null)
            {
                return NotFound();
            }
            return Ok(messages);
        }

        [HttpPost]
        [Authorize]
        [Route("")]
        public async Task<IActionResult> Create([FromBody] Message message)
        {
            message.Customer = await _customerRepository.Get(message.Order.Customer.Id);
            message.Freelancer = await _freelancerRepository.Get(message.Order.CurrentFreelancer.Id);
            message.Order = await _orderRepository.Get(message.Order.Id);
            message.PostedDate = DateTime.Now;
                await _messageRepository.Create(message);
            return Ok();
        }

    }

}
