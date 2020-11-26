using HINVenture.Shared.Models;
using HINVenture.Shared.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    public class SpecialitiesController : ControllerBase
    {
        private readonly IRepository<Speciality> _specialities;

        public SpecialitiesController(IRepository<Speciality> specialities)
        {
            _specialities = specialities;

        }

        // GET: api/ProductAPI
        [HttpGet]
        [Route("{action}")]
        [Authorize]
        public async Task<IEnumerable<Speciality>> GetAllSpecialities()
        {
            return await _specialities.GetAll().ToListAsync();
        }
    }
}
