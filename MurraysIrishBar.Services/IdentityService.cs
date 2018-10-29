using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using System.Security.Claims;

namespace MurraysIrishBar.Services
{
    public class IdentityService : IIdentityService
    {
        public ClaimsPrincipal CreateAutenticatedUser(string userNameEmail, string scheme)
        {
            return new ClaimsPrincipal(
                new ClaimsIdentity(
                        new[] { new Claim(ClaimTypes.Name, userNameEmail) },
                        scheme
                    )
                );
        }

        public string CreateCookieAuthenticationScheme()
        {
            return CookieAuthenticationDefaults.AuthenticationScheme;
        }

        public bool IsAdminUser(string userNameEmail, string password)
        {
            return userNameEmail == "admin@murraysbar.com"
                && password == "password#";
        }
    }
}
