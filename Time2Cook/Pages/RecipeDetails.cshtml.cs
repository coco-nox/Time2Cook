using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using Time2Cook.Models;

namespace Time2Cook
{
    public class RecipeDetailsModel : PageModel
    {
        public Recipe? Recipe { get; set; }
        public bool IsSaved { get; set; }
        public bool JustSaved { get; set; }
        public bool JustUnsaved { get; set; }

        public void OnGet(string name, bool saved = false, bool unsaved = false)
        {
            Recipe = RecipeData.GetRecipes().FirstOrDefault(r => r.Name == name);
            if (Recipe != null)
                IsSaved = GetSaved().Contains(Recipe.Name);
            JustSaved = saved;
            JustUnsaved = unsaved;
        }

        public IActionResult OnPostSave(string name)
        {
            if (User.Identity?.IsAuthenticated != true)
                return RedirectToPage("/Login", new { returnUrl = $"/RecipeDetails?name={Uri.EscapeDataString(name)}" });

            var saved = GetSaved();
            bool nowSaved;
            if (saved.Contains(name))
            {
                saved.Remove(name);
                nowSaved = false;
            }
            else
            {
                saved.Add(name);
                nowSaved = true;
            }
            SetSaved(saved);

            return RedirectToPage(new { name, saved = nowSaved ? "true" : null, unsaved = nowSaved ? null : "true" });
        }

        private List<string> GetSaved()
        {
            var json = HttpContext.Session.GetString("SavedRecipes");
            if (string.IsNullOrEmpty(json)) return new();
            return JsonSerializer.Deserialize<List<string>>(json) ?? new();
        }

        private void SetSaved(List<string> saved)
        {
            HttpContext.Session.SetString("SavedRecipes", JsonSerializer.Serialize(saved));
        }
    }
}
