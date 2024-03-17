using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using NSLPWasm.Dto;
using System.Security.Claims;

namespace NSLPWasm.Helpers
{
    public class LocalAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _storage;

        public LocalAuthenticationStateProvider(ILocalStorageService storage)
        {
            _storage = storage;
        }

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            if (await _storage.ContainKeyAsync("User"))
            {
                var userInfo = await _storage.GetItemAsync<AuthenticationDto>("User");



                var claims = new[]
                {
                    new Claim("UserName",userInfo.username)
                };



                var identity = new ClaimsIdentity(claims, "Bearer");
                var user = new ClaimsPrincipal(identity);
                var authstate = new AuthenticationState(user);



                NotifyAuthenticationStateChanged(Task.FromResult(authstate));
                return authstate;
            }

            return new AuthenticationState(new ClaimsPrincipal());
        }
    }
}
