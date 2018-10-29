using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MurraysIrishBar.Services;

namespace MurraysIrishBar.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        
        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        private readonly IIdentityService _identityService;

        public LoginModel(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public IActionResult OnPost()
        {
            //var isValidUser =
            //       EmailAddress == "admin@murraysbar.com"
            //    && Password == "password#";
            var isValidUser = _identityService.IsAdminUser(EmailAddress, Password);

            if (!isValidUser) {
                ModelState.AddModelError("", "Invalid username or password!");
            }

            if(!ModelState.IsValid)
            {
                return Page();
                
            }

            //var scheme = CookieAuthenticationDefaults.AuthenticationScheme;
            var scheme = _identityService.CreateCookieAuthenticationScheme();

            //var user = new ClaimsPrincipal(
            //    new ClaimsIdentity(
            //            new [] { new Claim(ClaimTypes.Name, EmailAddress) },
            //            scheme
            //        )
            //    );

            var user = _identityService.CreateAutenticatedUser(EmailAddress, scheme);

            return SignIn(user, scheme);
            
        }

        public async Task<IActionResult> OnPostLogoutAsync()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToPage("/Index");
        }
    }
}