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
                IngredientsList = new()
                {
                    "200g chicken breast",
                    "1 cup cooked rice",
                    "1/2 cucumber sliced",
                    "1 cup lettuce",
                    "1 tbsp olive oil",
                    "Salt and pepper"
                },
                Instructions = new()
                {
                    "Cook the rice according to the packet instructions.",
                    "Season the chicken with salt, pepper and olive oil.",
                    "Cook the chicken in a pan until fully cooked.",
                    "Slice the cucumber and prepare the lettuce.",
                    "Place rice into a bowl.",
                    "Add chicken, cucumber and lettuce.",
                    "Serve warm."
                },
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
                IngredientsList = new()
                {
                    "200g chicken breast",
                    "1 cup cooked rice",
                    "1 cup broccoli",
                    "1 capsicum sliced",
                    "2 tbsp soy sauce",
                    "1 tbsp oil"
                },
                Instructions = new()
                {
                    "Cook the rice and set it aside.",
                    "Cut the chicken into small pieces.",
                    "Heat oil in a pan.",
                    "Cook the chicken until browned.",
                    "Add broccoli and capsicum.",
                    "Add soy sauce and stir everything together.",
                    "Serve the stir fry with rice."
                },
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
                IngredientsList = new()
                {
                    "200g chicken breast",
                    "2 cups lettuce",
                    "1 tomato diced",
                    "1/2 avocado sliced",
                    "1 tbsp olive oil",
                    "Salt and pepper"
                },
                Instructions = new()
                {
                    "Season the chicken with salt, pepper and olive oil.",
                    "Grill or pan-fry the chicken until cooked through.",
                    "Let the chicken rest for a few minutes.",
                    "Chop the lettuce, tomato and avocado.",
                    "Place the salad ingredients into a bowl.",
                    "Slice the chicken and place it on top.",
                    "Serve with a light dressing or lemon juice."
                },
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
                IngredientsList = new()
                {
                    "200g chicken mince",
                    "6 lettuce leaves",
                    "1 carrot grated",
                    "1/2 cucumber sliced",
                    "1 tbsp soy sauce or garlic sauce"
                },
                Instructions = new()
                {
                    "Cook the chicken mince in a pan until fully cooked.",
                    "Season the chicken with garlic, salt and pepper.",
                    "Wash the lettuce leaves and keep them whole.",
                    "Prepare the carrot and cucumber.",
                    "Spoon the chicken into each lettuce leaf.",
                    "Add carrot and cucumber on top.",
                    "Fold the lettuce and serve."
                },
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
                IngredientsList = new()
                {
                    "200g beef mince",
                    "1 cup cooked rice",
                    "1/2 cup black beans",
                    "1/2 cup corn",
                    "1 tomato diced",
                    "1/2 avocado"
                },
                Instructions = new()
                {
                    "Cook the rice and set it aside.",
                    "Cook the beef mince in a pan until browned.",
                    "Add beans, corn and tomato.",
                    "Stir everything together and cook for a few minutes.",
                    "Place rice into a bowl.",
                    "Add the beef mixture on top.",
                    "Serve with avocado or salsa."
                },
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
                IngredientsList = new()
                {
                    "200g beef mince or beef strips",
                    "1 cup cooked rice",
                    "1 cup broccoli",
                    "1 carrot sliced",
                    "1 tbsp soy sauce or garlic sauce"
                },
                Instructions = new()
                {
                    "Cook the rice according to packet instructions.",
                    "Cook the beef in a pan until browned.",
                    "Add broccoli and carrot.",
                    "Cook until the vegetables soften.",
                    "Place rice into a bowl.",
                    "Add beef and vegetables on top.",
                    "Serve hot."
                },
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
                IngredientsList = new()
                {
                    "200g beef mince",
                    "6 lettuce leaves",
                    "1 carrot grated",
                    "1/2 cucumber diced",
                    "1 tbsp garlic sauce"
                },
                Instructions = new()
                {
                    "Cook the beef mince in a pan.",
                    "Season with garlic, salt and pepper.",
                    "Wash the lettuce leaves.",
                    "Prepare the carrot and cucumber.",
                    "Spoon beef into each lettuce cup.",
                    "Add carrot and cucumber on top.",
                    "Serve immediately."
                },
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
                IngredientsList = new()
                {
                    "200g beef mince",
                    "1 cup cooked rice",
                    "2 tomatoes diced",
                    "1 cup spinach",
                    "1 tbsp olive oil",
                    "Salt and pepper"
                },
                Instructions = new()
                {
                    "Cook the rice or use leftover rice.",
                    "Heat oil in a pan.",
                    "Cook the beef mince until browned.",
                    "Add tomato and spinach.",
                    "Cook until the tomato softens and the spinach wilts.",
                    "Place rice into a bowl.",
                    "Add the beef and tomato mixture on top."
                },
                Image = "/images/Vietnamese-Caramelized-Minced-Beef-Rice-Bowls.jpg"
            },

            new Recipe
            {
                Name = "Tuna Rice Bowl",
                Protein = "Fish",
                Ingredients = "tuna rice cucumber corn",
                DietType = "Pescatarian",
                Allergens = "Fish",
                Cost = "$3.50",
                CostValue = 3.50m,
                Calories = 430,
                Time = "10 mins",
                Minutes = 10,
                IngredientsList = new()
                {
                    "95g canned tuna",
                    "1 cup cooked rice",
                    "1/2 cucumber diced",
                    "1/2 cup corn",
                    "Salt and pepper"
                },
                Instructions = new()
                {
                    "Cook the rice or use leftover rice.",
                    "Drain the tuna.",
                    "Dice the cucumber.",
                    "Place rice into a bowl.",
                    "Add tuna, cucumber and corn.",
                    "Season with salt and pepper.",
                    "Serve immediately."
                },
                Image = "/images/sesame-crusted-tuna-rice-bowls.jpg"
            },

            new Recipe
            {
                Name = "Quick Tuna Cucumber Rice Bowl",
                Protein = "Fish",
                Ingredients = "tuna rice cucumber",
                DietType = "Pescatarian",
                Allergens = "Fish",
                Cost = "$3.40",
                CostValue = 3.40m,
                Calories = 390,
                Time = "10 mins",
                Minutes = 10,
                IngredientsList = new()
                {
                    "95g canned tuna",
                    "1 cup cooked rice",
                    "1 cucumber sliced",
                    "1 tsp soy sauce"
                },
                Instructions = new()
                {
                    "Prepare the rice.",
                    "Drain the tuna.",
                    "Slice the cucumber.",
                    "Place rice in a bowl.",
                    "Top with tuna and cucumber.",
                    "Drizzle with soy sauce.",
                    "Serve fresh."
                },
                Image = "/images/Tuna-Mornay_6.jpg"
            },

            new Recipe
            {
                Name = "Grilled Salmon Salad",
                Protein = "Fish",
                Ingredients = "salmon lettuce tomato avocado",
                DietType = "Pescatarian, Gluten Free",
                Allergens = "Fish",
                Cost = "$6.50",
                CostValue = 6.50m,
                Calories = 470,
                Time = "20 mins",
                Minutes = 20,
                IngredientsList = new()
                {
                    "200g salmon fillet",
                    "2 cups lettuce",
                    "1 tomato",
                    "1/2 avocado",
                    "1 tbsp olive oil"
                },
                Instructions = new()
                {
                    "Season the salmon.",
                    "Cook the salmon until flaky.",
                    "Prepare the salad vegetables.",
                    "Place vegetables into a bowl.",
                    "Break salmon into chunks.",
                    "Place salmon on top.",
                    "Serve with dressing."
                },
                Image = "/images/sesame-crusted-tuna-rice-bowls.jpg"
            },

            new Recipe
            {
                Name = "Fish Avocado Salad",
                Protein = "Fish",
                Ingredients = "fish avocado lettuce cucumber",
                DietType = "Pescatarian, Low Carb",
                Allergens = "Fish",
                Cost = "$5.80",
                CostValue = 5.80m,
                Calories = 410,
                Time = "15 mins",
                Minutes = 15,
                IngredientsList = new()
                {
                    "150g white fish",
                    "1 avocado",
                    "2 cups lettuce",
                    "1 cucumber",
                    "1 tbsp lemon juice"
                },
                Instructions = new()
                {
                    "Cook the fish until fully cooked.",
                    "Slice the avocado and cucumber.",
                    "Prepare the lettuce.",
                    "Place vegetables into a bowl.",
                    "Add fish on top.",
                    "Drizzle with lemon juice.",
                    "Serve immediately."
                },
                Image = "/images/sesame-crusted-tuna-rice-bowls.jpg"
            },

            new Recipe
            {
                Name = "Sesame Tuna Bowl",
                Protein = "Fish",
                Ingredients = "tuna rice sesame cucumber",
                DietType = "Pescatarian",
                Allergens = "Fish, Sesame",
                Cost = "$6.20",
                CostValue = 6.20m,
                Calories = 520,
                Time = "20 mins",
                Minutes = 20,
                IngredientsList = new()
                {
                    "200g tuna steak",
                    "1 cup rice",
                    "1 cucumber",
                    "1 tbsp sesame seeds",
                    "1 tbsp soy sauce"
                },
                Instructions = new()
                {
                    "Cook the rice.",
                    "Coat tuna lightly with sesame seeds.",
                    "Cook tuna to desired doneness.",
                    "Slice the cucumber.",
                    "Place rice into a bowl.",
                    "Top with tuna and cucumber.",
                    "Drizzle with soy sauce."
                },
                Image = "/images/sesame-crusted-tuna-rice-bowls.jpg"
            },

            new Recipe
            {
                Name = "Vegetable Fried Rice",
                Protein = "Vegetarian",
                Ingredients = "rice carrot peas corn",
                DietType = "Vegetarian",
                Allergens = "None",
                Cost = "$2.80",
                CostValue = 2.80m,
                Calories = 380,
                Time = "15 mins",
                Minutes = 15,
                IngredientsList = new()
                {
                    "1 cup cooked rice",
                    "1 carrot diced",
                    "1/2 cup peas",
                    "1/2 cup corn",
                    "1 tbsp soy sauce"
                },
                Instructions = new()
                {
                    "Heat a pan over medium heat.",
                    "Cook carrot until slightly softened.",
                    "Add peas and corn.",
                    "Add cooked rice.",
                    "Mix thoroughly.",
                    "Add soy sauce and stir.",
                    "Serve hot."
                },
                Image = "/images/Vegetable Fried Rice (no egg).jpg"
            },

            new Recipe
            {
                Name = "Veggie Stuffed Omelet",
                Protein = "Vegetarian",
                Ingredients = "eggs capsicum spinach mushroom",
                DietType = "Vegetarian",
                Allergens = "Egg",
                Cost = "$3.00",
                CostValue = 3.00m,
                Calories = 350,
                Time = "15 mins",
                Minutes = 15,
                IngredientsList = new()
                {
                    "3 eggs",
                    "1/2 capsicum diced",
                    "1/2 cup spinach",
                    "1/2 cup mushrooms",
                    "Salt and pepper"
                },
                Instructions = new()
                {
                    "Whisk eggs in a bowl.",
                    "Cook vegetables in a pan.",
                    "Pour eggs over vegetables.",
                    "Cook until mostly set.",
                    "Fold omelet in half.",
                    "Cook for another minute.",
                    "Serve warm."
                },
                Image = "/images/Veggie Stuffed Omelet.jpg"
            },

            new Recipe
            {
                Name = "Avocado Toast with Egg",
                Protein = "Vegetarian",
                Ingredients = "bread avocado egg",
                DietType = "Vegetarian",
                Allergens = "Egg, Gluten",
                Cost = "$2.50",
                CostValue = 2.50m,
                Calories = 340,
                Time = "10 mins",
                Minutes = 10,
                IngredientsList = new()
                {
                    "2 slices bread",
                    "1 avocado",
                    "1 egg",
                    "Salt and pepper"
                },
                Instructions = new()
                {
                    "Toast the bread.",
                    "Mash the avocado.",
                    "Cook the egg.",
                    "Spread avocado on toast.",
                    "Place egg on top.",
                    "Season to taste.",
                    "Serve immediately."
                },
                Image = "/images/avocado-toast-with-egg.jpg"
            },

            new Recipe
            {
                Name = "Black Bean Tacos",
                Protein = "Vegan",
                Ingredients = "black beans tortillas lettuce tomato",
                DietType = "Vegan",
                Allergens = "Gluten",
                Cost = "$3.20",
                CostValue = 3.20m,
                Calories = 420,
                Time = "15 mins",
                Minutes = 15,
                IngredientsList = new()
                {
                    "1 can black beans",
                    "4 tortillas",
                    "1 cup lettuce",
                    "1 tomato diced"
                },
                Instructions = new()
                {
                    "Heat black beans in a saucepan.",
                    "Warm tortillas.",
                    "Prepare lettuce and tomato.",
                    "Fill tortillas with beans.",
                    "Add vegetables.",
                    "Fold tacos.",
                    "Serve immediately."
                },
                Image = "/images/black-bean-tacos-.jpg"
            },

            new Recipe
            {
                Name = "Vegan Lentil Soup",
                Protein = "Vegan",
                Ingredients = "lentils carrot celery onion",
                DietType = "Vegan",
                Allergens = "None",
                Cost = "$2.90",
                CostValue = 2.90m,
                Calories = 310,
                Time = "30 mins",
                Minutes = 30,
                IngredientsList = new()
                {
                    "1 cup lentils",
                    "1 carrot",
                    "1 celery stalk",
                    "1 onion",
                    "4 cups vegetable stock"
                },
                Instructions = new()
                {
                    "Dice all vegetables.",
                    "Cook onion until soft.",
                    "Add carrot and celery.",
                    "Add lentils and stock.",
                    "Bring to a boil.",
                    "Simmer for 25 minutes.",
                    "Serve hot."
                },
                Image = "/images/buffalo-chickpea-bowl.jpg"
            },

            new Recipe
            {
                Name = "Buffalo Chickpea Bowl",
                Protein = "Vegan",
                Ingredients = "chickpeas rice lettuce buffalo sauce",
                DietType = "Vegan",
                Allergens = "None",
                Cost = "$3.50",
                CostValue = 3.50m,
                Calories = 440,
                Time = "15 mins",
                Minutes = 15,
                IngredientsList = new()
                {
                    "1 can chickpeas",
                    "1 cup rice",
                    "1 cup lettuce",
                    "2 tbsp buffalo sauce"
                },
                Instructions = new()
                {
                    "Cook rice if needed.",
                    "Drain chickpeas.",
                    "Heat chickpeas in a pan.",
                    "Mix with buffalo sauce.",
                    "Place rice into a bowl.",
                    "Add lettuce and chickpeas.",
                    "Serve immediately."
                },
                Image = "/images/buffalo-chickpea-bowl.jpg"
            },

            new Recipe
            {
                Name = "Healthy Burrito Bowl",
                Protein = "Vegan",
                Ingredients = "rice beans corn avocado",
                DietType = "Vegan",
                Allergens = "None",
                Cost = "$4.00",
                CostValue = 4.00m,
                Calories = 520,
                Time = "20 mins",
                Minutes = 20,
                IngredientsList = new()
                {
                    "1 cup rice",
                    "1/2 cup black beans",
                    "1/2 cup corn",
                    "1 avocado"
                },
                Instructions = new()
                {
                    "Cook rice.",
                    "Prepare beans and corn.",
                    "Slice avocado.",
                    "Place rice into bowl.",
                    "Add beans and corn.",
                    "Top with avocado.",
                    "Serve fresh."
                },
                Image = "/images/Healthy Burrito Bowls.jpg"
            }
            };
        }
    }
}