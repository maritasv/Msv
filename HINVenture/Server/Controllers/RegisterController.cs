using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using HINVenture.Client;
using HINVenture.Shared.Models;
using HINVenture.Shared.Models.Entities;
using HINVenture.Shared.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HINVenture.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {     
        private readonly UserManager<ApplicationUser> _userManager;

        public RegisterController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        
        [HttpPost]
        [Route("{action}")]
        public async Task<IActionResult> Freelancer([FromBody] RegisterModel model)
        {
            var newUser = new ApplicationUser { UserName = model.Email, Email = model.Email };

            try
            {
                newUser.FreelancerUser = new FreelancerUser();
                var result = await _userManager.CreateAsync(newUser, model.Password);
                await _userManager.AddToRoleAsync(newUser, "freelancer");
                if (!result.Succeeded)
                {
                    var errors = result.Errors.Select(x => x.Description);
                    return Ok(new RegisterResult { Successful = false, Errors = errors });
                }
            }
            catch (Exception ex)
            {

            }

            return Ok(new RegisterResult { Successful = true });
        }

        [HttpPost]
        [Route("{action}")]
        public async Task<IActionResult> Customer([FromBody] RegisterModel model)
        {
            var newUser = new ApplicationUser { UserName = model.Email, Email = model.Email };
            try
            {
                newUser.CustomerUser = new CustomerUser();
                var result = await _userManager.CreateAsync(newUser, model.Password);
                await _userManager.AddToRoleAsync(newUser, "customer");
                if (!result.Succeeded)
                {
                    var errors = result.Errors.Select(x => x.Description);
                    return Ok(new RegisterResult { Successful = false, Errors = errors });
                }
            }
            catch (Exception ex)
            {

            }

            return Ok(new RegisterResult { Successful = true });
        }
    }
}
