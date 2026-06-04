using Microsoft.AspNetCore.Mvc.RazorPages;
using Time2Cook.Models;

namespace Time2Cook
{
    public class RecipeResultsModel : PageModel
    {
        public string Ingredients { get; set; } = "";
        public string SearchQueryString { get; set; } = "";
        public List<Recipe> Recipes { get; set; } = new();

        public void OnGet(
            string ingredients,
            int maxBudget = 20,
            int maxTime = 60,
            string calorieGoal = "none",
            string[]? dietary = null,
            string[]? allergies = null)
        {
            Ingredients = ingredients ?? "";
            SearchQueryString = Request.QueryString.Value ?? "";

            var recipes = RecipeData.GetRecipes();

            if (!string.IsNullOrWhiteSpace(Ingredients))
            {
                var entered = Ingredients
                    .ToLower()
                    .Split(new[] { ',', ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(i => i.Trim())
                    .Where(i => i.Length > 1)
                    .ToList();

                recipes = recipes
                    .Where(r => entered.Any(i =>
                        r.Ingredients.ToLower().Contains(i) ||
                        r.Protein.ToLower().Contains(i)))
                    .ToList();
            }

            recipes = recipes
                .Where(r => r.CostValue <= maxBudget)
                .Where(r => r.Minutes <= maxTime)
                .ToList();

            if (calorieGoal == "weightLoss")
                recipes = recipes.Where(r => r.Calories <= 450).ToList();
            else if (calorieGoal == "maintenance")
                recipes = recipes.Where(r => r.Calories <= 650).ToList();
            else if (calorieGoal == "muscleGain")
                recipes = recipes.Where(r => r.Calories >= 500).ToList();

            if (dietary != null && dietary.Length > 0)
            {
                recipes = recipes
                    .Where(r => dietary.All(d =>
                        r.DietType.ToLower().Contains(d.ToLower())))
                    .ToList();
            }

            if (allergies != null && allergies.Length > 0)
            {
                recipes = recipes
                    .Where(r => allergies.All(a =>
                        !r.Allergens.ToLower().Contains(a.ToLower())))
                    .ToList();
            }

            Recipes = recipes;
        }
    }
}
