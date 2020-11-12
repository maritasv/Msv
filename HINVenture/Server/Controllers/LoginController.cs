using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using HINVenture.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace HINVenture.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> _userManager;

        public LoginController(IConfiguration configuration,
<<<<<<< HEAD
            SignInManager<IdentityUser> signInManager)
=======
                               UserManager<ApplicationUser> userManager)
>>>>>>> 27857c811214957d9a4ebf14359df42c676ac3d3
        {
            _configuration = configuration;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginModel login)
        {
            var user = await _userManager.FindByNameAsync(login.Email);
            if (user == null) return BadRequest(new LoginResult { Successful = false, Error = "Username and password are invalid." });

<<<<<<< HEAD
            if (!result.Succeeded)
                return BadRequest(new LoginResult {Successful = false, Error = "Username and password are invalid."});
=======
            var result = await _userManager.CheckPasswordAsync(user, login.Password);

            if (!result) return BadRequest(new LoginResult { Successful = false, Error = "Username and password are invalid." });
>>>>>>> 27857c811214957d9a4ebf14359df42c676ac3d3

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, login.Email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpiryInDays"]));

            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtAudience"],
                claims,
                expires: expiry,
                signingCredentials: creds
            );

            return Ok(new LoginResult {Successful = true, Token = new JwtSecurityTokenHandler().WriteToken(token)});
        }
    }
}