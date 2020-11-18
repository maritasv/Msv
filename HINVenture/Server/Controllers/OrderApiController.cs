using HINVenture.Shared.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HINVenture.Shared.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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

        
        private bool OrderExists(int id)
        {
            return false;
        }

    }
}