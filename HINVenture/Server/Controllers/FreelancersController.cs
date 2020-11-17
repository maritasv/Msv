using HINVenture.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HINVenture.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FreelancersController : Controller
    {
        private static readonly string[] Summaries = new[]
          {
            "Python", "C++", "Java", "C#", "Javascript"
        };

        private readonly ILogger<FreelancersController> logger;

        public FreelancersController(ILogger<FreelancersController> logger)
        {
            this.logger = logger;
        }

       
    }
}
