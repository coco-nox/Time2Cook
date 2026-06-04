using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Time2Cook.Models;

namespace Time2Cook.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public RegisterInput Input { get; set; } = new();

        public string? ErrorMessage { get; set; }

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            if (Input.Password != Input.ConfirmPassword)
            {
                ErrorMessage = "Passwords do not match.";
                return Page();
            }

            if (!UserStore.Register(Input.Email, Input.Password, out var error))
            {
                ErrorMessage = error;
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

            return RedirectToPage("/Index");
        }
    }

    public class RegisterInput
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "";

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = "";
    }
}
