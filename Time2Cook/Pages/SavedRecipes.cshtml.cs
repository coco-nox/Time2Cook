using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using Time2Cook.Models;

namespace Time2Cook
{
    public class SavedRecipesModel : PageModel
    {
        public List<Recipe> Recipes { get; set; } = new();
        public bool IsLoggedIn { get; set; }

        public void OnGet()
        {
            IsLoggedIn = User.Identity?.IsAuthenticated == true;
            if (IsLoggedIn)
            {
                var saved = GetSaved();
                Recipes = RecipeData.GetRecipes()
                    .Where(r => saved.Contains(r.Name))
                    .ToList();
            }
        }

        public IActionResult OnPostRemove(string name)
        {
            if (User.Identity?.IsAuthenticated != true)
                return RedirectToPage("/Login");

            var saved = GetSaved();
            saved.Remove(name);
            SetSaved(saved);
            return RedirectToPage();
        }

        public IActionResult OnPostClear()
        {
            if (User.Identity?.IsAuthenticated != true)
                return RedirectToPage("/Login");

            SetSaved(new List<string>());
            return RedirectToPage();
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
