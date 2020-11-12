using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using HINVenture.Client.Providers;
using HINVenture.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HINVenture.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly ApiAuthenticationStateProvider _stateProvider;

        public AccountController(HttpClient httpClient, ApiAuthenticationStateProvider stateProvider)
        {
            _httpClient = httpClient;
            _stateProvider = stateProvider;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var json = JsonConvert.SerializeObject(model);
                var result = await _httpClient.PostAsync("Login",
                    new StringContent(json, Encoding.UTF8, "application/json"));
                var loginResult = JsonConvert.DeserializeObject<LoginResult>(await result.Content.ReadAsStringAsync());
                if (loginResult.Successful)
                {
                    _stateProvider.MarkUserAsAuthenticated(model.Email);
                    _httpClient.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("bearer", loginResult.Token);

                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            var json = JsonConvert.SerializeObject(model);
            var result =
                await _httpClient.PostAsync("Register", new StringContent(json, Encoding.UTF8, "application/json"));
            var registerResult =
                JsonConvert.DeserializeObject<RegisterResult>(await result.Content.ReadAsStringAsync());
            if (registerResult.Successful)
                return RedirectToAction("Index", "Home");

            return View(model);
        }

        [HttpPost]
        public IActionResult Logout()
        {
            _stateProvider.MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
            return View();
        }
    }
}