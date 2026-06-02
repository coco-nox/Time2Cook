using System.Collections.Generic;

namespace Time2Cook.Models
{
    public static class RecipeData
    {
        public static List<Recipe> GetRecipes()
        {
            return new List<Recipe>
            {
                new Recipe
                {
                    Name = "Chicken Rice Bowl",
                    Protein = "Chicken",
                    Ingredients = "chicken rice cucumber lettuce",
                    DietType = "Halal",
                    Allergens = "None",
                    Cost = "$4.50",
                    CostValue = 4.50m,
                    Calories = 520,
                    Time = "20 mins",
                    Minutes = 20,
                    Image = "/images/Spiced chicken rice bowl.jpg"
                },

                new Recipe
                {
                    Name = "Chicken Stir Fry",
                    Protein = "Chicken",
                    Ingredients = "chicken rice broccoli capsicum soy sauce",
                    DietType = "Halal",
                    Allergens = "Soy",
                    Cost = "$5.00",
                    CostValue = 5.00m,
                    Calories = 580,
                    Time = "25 mins",
                    Minutes = 25,
                    Image = "/images/Chicken Stir Fry.jpg"
                },

                new Recipe
                {
                    Name = "Grilled Chicken Salad",
                    Protein = "Chicken",
                    Ingredients = "chicken lettuce tomato avocado",
                    DietType = "Gluten Free",
                    Allergens = "None",
                    Cost = "$4.20",
                    CostValue = 4.20m,
                    Calories = 390,
                    Time = "15 mins",
                    Minutes = 15,
                    Image = "/images/Grilled Chicken Salad.jpg"
                },

                new Recipe
                {
                    Name = "Chicken Lettuce Wraps",
                    Protein = "Chicken",
                    Ingredients = "chicken lettuce carrot cucumber",
                    DietType = "Halal, Gluten Free, Low Carb",
                    Allergens = "None",
                    Cost = "$4.00",
                    CostValue = 4.00m,
                    Calories = 360,
                    Time = "15 mins",
                    Minutes = 15,
                    Image = "/images/Thai Chicken Lettuce Wraps.jpg"
                },

                new Recipe
                {
                    Name = "Beef Burrito Bowl",
                    Protein = "Beef",
                    Ingredients = "beef rice beans corn tomato",
                    DietType = "Gluten Free",
                    Allergens = "None",
                    Cost = "$5.50",
                    CostValue = 5.50m,
                    Calories = 650,
                    Time = "30 mins",
                    Minutes = 30,
                    Image = "/images/Healthy Burrito Bowls.jpg"
                },

                new Recipe
                {
                    Name = "Beef Rice Bowl",
                    Protein = "Beef",
                    Ingredients = "beef rice broccoli carrot",
                    DietType = "Halal",
                    Allergens = "None",
                    Cost = "$5.20",
                    CostValue = 5.20m,
                    Calories = 610,
                    Time = "25 mins",
                    Minutes = 25,
                    Image = "/images/Vietnamese-Caramelized-Minced-Beef-Rice-Bowls.jpg"
                },

                new Recipe
                {
                    Name = "Beef Lettuce Cups",
                    Protein = "Beef",
                    Ingredients = "beef lettuce cucumber carrot",
                    DietType = "Low Carb, Gluten Free",
                    Allergens = "None",
                    Cost = "$4.80",
                    CostValue = 4.80m,
                    Calories = 430,
                    Time = "15 mins",
                    Minutes = 15,
                    Image = "/images/vietnamese-beef-lettuce-cups.jpg"
                },

                new Recipe
                {
                    Name = "Quick Beef Tomato Bowl",
                    Protein = "Beef",
                    Ingredients = "beef tomato rice spinach",
                    DietType = "Halal",
                    Allergens = "None",
                    Cost = "$4.90",
                    CostValue = 4.90m,
                    Calories = 540,
                    Time = "20 mins",
                    Minutes = 20,
                    Image = "/images/Vietnamese-Caramelized-Minced-Beef-Rice-Bowls.jpg"
                },

                new Recipe
                {
                    Name = "Tuna Rice Bowl",
                    Protein = "Fish",
                    Ingredients = "tuna rice cucumber corn",
                    DietType = "High Protein",
                    Allergens = "Fish",
                    Cost = "$3.50",
                    CostValue = 3.50m,
                    Calories = 430,
                    Time = "10 mins",
                    Minutes = 10,
                    Image = "/images/Tuna-Mornay_6.jpg"
                },

                new Recipe
                {
                    Name = "Quick Tuna Cucumber Rice Bowl",
                    Protein = "Fish",
                    Ingredients = "tuna rice cucumber corn",
                    DietType = "High Protein",
                    Allergens = "Fish",
                    Cost = "$3.40",
                    CostValue = 3.40m,
                    Calories = 390,
                    Time = "10 mins",
                    Minutes = 10,
                    Image = "/images/sesame-crusted-tuna-rice-bowls.jpg"
                },

                new Recipe
                {
                    Name = "Grilled Salmon Salad",
                    Protein = "Fish",
                    Ingredients = "salmon lettuce tomato avocado",
                    DietType = "Gluten Free",
                    Allergens = "Fish",
                    Cost = "$6.50",
                    CostValue = 6.50m,
                    Calories = 470,
                    Time = "20 mins",
                    Minutes = 20,
                    Image = "/images/sesame-crusted-tuna-rice-bowls.jpg"
                },

                new Recipe
                {
                    Name = "Fish Avocado Salad",
                    Protein = "Fish",
                    Ingredients = "fish avocado lettuce cucumber tomato",
                    DietType = "Gluten Free, Low Carb",
                    Allergens = "Fish",
                    Cost = "$5.80",
                    CostValue = 5.80m,
                    Calories = 410,
                    Time = "15 mins",
                    Minutes = 15,
                    Image = "/images/sesame-crusted-tuna-rice-bowls.jpg"
                },

                new Recipe
                {
                    Name = "Vegan Chickpea Bowl",
                    Protein = "Chickpeas",
                    Ingredients = "chickpeas rice cucumber tomato",
                    DietType = "Vegan, Dairy Free",
                    Allergens = "None",
                    Cost = "$3.00",
                    CostValue = 3.00m,
                    Calories = 390,
                    Time = "15 mins",
                    Minutes = 15,
                    Image = "/images/buffalo-chickpea-bowl.jpg"
                },

                new Recipe
                {
                    Name = "Lentil Soup",
                    Protein = "Lentils",
                    Ingredients = "lentils onion carrot celery",
                    DietType = "Vegan, Dairy Free",
                    Allergens = "None",
                    Cost = "$2.50",
                    CostValue = 2.50m,
                    Calories = 320,
                    Time = "30 mins",
                    Minutes = 30,
                    Image = "/images/buffalo-chickpea-bowl.jpg"
                },

                new Recipe
                {
                    Name = "Vegan Bean Tacos",
                    Protein = "Beans",
                    Ingredients = "beans tortilla lettuce tomato corn",
                    DietType = "Vegan, Dairy Free",
                    Allergens = "Gluten",
                    Cost = "$2.80",
                    CostValue = 2.80m,
                    Calories = 460,
                    Time = "15 mins",
                    Minutes = 15,
                    Image = "/images/black-bean-tacos-.jpg"
                },

                new Recipe
                {
                    Name = "Tofu Veggie Bowl",
                    Protein = "Tofu",
                    Ingredients = "tofu rice broccoli carrot",
                    DietType = "Vegan, Dairy Free",
                    Allergens = "Soy",
                    Cost = "$3.60",
                    CostValue = 3.60m,
                    Calories = 420,
                    Time = "20 mins",
                    Minutes = 20,
                    Image = "/images/buffalo-chickpea-bowl.jpg"
                },

                new Recipe
                {
                    Name = "Vegetarian Omelette",
                    Protein = "Eggs",
                    Ingredients = "eggs cheese spinach tomato",
                    DietType = "Vegetarian",
                    Allergens = "Eggs,Dairy",
                    Cost = "$2.20",
                    CostValue = 2.20m,
                    Calories = 350,
                    Time = "10 mins",
                    Minutes = 10,
                    Image = "/images/Veggie Stuffed Omelet.jpg"
                },

                new Recipe
                {
                    Name = "Egg Avocado Toast",
                    Protein = "Eggs",
                    Ingredients = "eggs bread avocado tomato",
                    DietType = "Vegetarian",
                    Allergens = "Eggs, Gluten",
                    Cost = "$3.20",
                    CostValue = 3.20m,
                    Calories = 430,
                    Time = "10 mins",
                    Minutes = 10,
                    Image = "/images/avocado-toast-with-egg.jpg"
                },

                new Recipe
                {
                    Name = "Vegetarian Fried Rice",
                    Protein = "Eggs",
                    Ingredients = "egg rice peas carrot corn",
                    DietType = "Vegetarian",
                    Allergens = "Eggs",
                    Cost = "$2.90",
                    CostValue = 2.90m,
                    Calories = 440,
                    Time = "15 mins",
                    Minutes = 15,
                    Image = "/images/Vegetable Fried Rice (no egg).jpg"
                },

                new Recipe
                {
                    Name = "Tomato Pasta",
                    Protein = "None",
                    Ingredients = "pasta tomato garlic basil",
                    DietType = "Vegetarian, Vegan, Dairy Free",
                    Allergens = "Gluten",
                    Cost = "$2.60",
                    CostValue = 2.60m,
                    Calories = 450,
                    Time = "20 mins",
                    Minutes = 20,
                    Image = "/images/Vegetable Fried Rice (no egg).jpg"
                }
            };
        }
    }
}