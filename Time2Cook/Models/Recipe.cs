using System.Collections.Generic;

namespace Time2Cook.Models
{
    public class Recipe
    {
        public string Name { get; set; } = "";

        public string Protein { get; set; } = "";

        public string Ingredients { get; set; } = "";

        public List<string> IngredientsList { get; set; } = new();

        public List<string> Instructions { get; set; } = new();

        public string DietType { get; set; } = "";

        public string Allergens { get; set; } = "";

        public string Cost { get; set; } = "";

        public decimal CostValue { get; set; }

        public int Calories { get; set; }

        public string Time { get; set; } = "";

        public int Minutes { get; set; }

        public string Image { get; set; } = "";
    }
}