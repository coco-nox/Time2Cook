using Microsoft.AspNetCore.Mvc.RazorPages;
using Time2Cook.Models;

namespace Time2Cook
{
    public class RecipeDetailsModel : PageModel
    {
        public Recipe? Recipe { get; set; }

        public void OnGet(string name)
        {
            Recipe = RecipeData.GetRecipes()
                .FirstOrDefault(r => r.Name == name);
        }
    }
}