using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Time2Cook.Models;

namespace Time2Cook.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LoginInput Input { get; set; } = new();

        public string? ErrorMessage { get; set; }

        public string ReturnUrl { get; set; } = "/";

        public void OnGet(string? returnUrl = null)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public async Task<IActionResult> OnPostAsync(string? returnUrl = null)
        {
            ReturnUrl = returnUrl ?? "/";

            if (!ModelState.IsValid)
                return Page();

            if (!UserStore.Validate(Input.Email, Input.Password))
            {
                ErrorMessage = "Invalid email or password. Please try again.";
                return Page();
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, Input.Email.Trim().ToLower()),
                new Claim(ClaimTypes.Email, Input.Email.Trim().ToLower())
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(identity));

            return LocalRedirect(Url.IsLocalUrl(ReturnUrl) ? ReturnUrl : "/");
        }
    }

    public class LoginInput
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "";
    }
}
