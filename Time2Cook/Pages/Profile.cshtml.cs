using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Time2Cook.Models;

namespace Time2Cook.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        public string Email { get; set; } = "";
        public string Avatar { get; set; } = "";
        public DateTime? JoinedAt { get; set; }
        public int SavedCount { get; set; }

        [BindProperty]
        public PasswordChangeInput Input { get; set; } = new();

        public string? SuccessMessage { get; set; }
        public string? ErrorMessage { get; set; }

        public void OnGet()
        {
            LoadProfile();
        }

        public IActionResult OnPostChangePassword()
        {
            LoadProfile();

            if (!ModelState.IsValid)
                return Page();

            if (Input.NewPassword != Input.ConfirmNewPassword)
            {
                ErrorMessage = "New passwords do not match.";
                return Page();
            }

            if (!UserStore.ChangePassword(Email, Input.CurrentPassword, Input.NewPassword, out var error))
            {
                ErrorMessage = error;
                return Page();
            }

            SuccessMessage = "Password updated successfully.";
            Input = new();
            return Page();
        }

        private void LoadProfile()
        {
            Email = User.Identity?.Name ?? "";
            Avatar = Email.Length > 0 ? Email[0].ToString().ToUpper() : "?";
            JoinedAt = UserStore.GetJoinDate(Email);
            var json = HttpContext.Session.GetString("SavedRecipes");
            SavedCount = string.IsNullOrEmpty(json)
                ? 0
                : (JsonSerializer.Deserialize<List<string>>(json)?.Count ?? 0);
        }
    }

    public class PasswordChangeInput
    {
        [Required(ErrorMessage = "Current password is required.")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; } = "";

        [Required(ErrorMessage = "New password is required.")]
        [MinLength(6, ErrorMessage = "New password must be at least 6 characters.")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; } = "";

        [Required(ErrorMessage = "Please confirm your new password.")]
        [DataType(DataType.Password)]
        public string ConfirmNewPassword { get; set; } = "";
    }
}
