using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace MurraysIrishBar.Services
{
    public interface IIdentityService
    {
        bool IsAdminUser(string userNameEmail, string password);

        string CreateCookieAuthenticationScheme();

        ClaimsPrincipal CreateAutenticatedUser(string userNameEmail, string scheme);
    }
}
