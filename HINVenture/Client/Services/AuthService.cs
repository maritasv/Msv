using Blazored.LocalStorage;
using HINVenture.Shared.Models;
using HINVenture.Shared.Models.ViewModels;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace HINVenture.Client.Services
{
    public class AuthService
    {

        private readonly HttpClient _httpClient;
        private readonly ApiAuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;

        public AuthService(HttpClient httpClient,
                           ApiAuthenticationStateProvider authenticationStateProvider,
                           ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
        }

        public async Task<RegisterResult> RegisterFreelancer(RegisterModel registerModel)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Register/Freelancer", registerModel);
            return await response.Content.ReadFromJsonAsync<RegisterResult>();
        }

        public async Task<RegisterResult> RegisterCustomer(RegisterModel registerModel)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Register/Customer", registerModel);
            return await response.Content.ReadFromJsonAsync<RegisterResult>();
        }




        public async Task<LoginResult> Login(LoginModel loginModel)
        {

            var response = await _httpClient.PostAsJsonAsync("api/login", loginModel);
            var loginResult = await response.Content.ReadFromJsonAsync<LoginResult>();

            if (!response.IsSuccessStatusCode)
            {
                return loginResult;
            }

            await _localStorage.SetItemAsync("authToken", loginResult.Token);
            
            _authenticationStateProvider.MarkUserAsAuthenticated(loginModel.Email);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", loginResult.Token);

            return loginResult;
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }
    }
}


