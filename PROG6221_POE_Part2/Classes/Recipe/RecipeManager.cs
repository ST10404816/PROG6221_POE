// Lisha Naidoo
// ST10404816
// Group 1

/*
 References

 Dotnetforall. 2024. Create and Invoke C# Delegate, 5 July 2019. [Online]. Avaialable at: https://www.dotnetforall.com/create-and-invoke-csharp-delegate/ [Accessed 25 May 2024].
 Geeksforgeeks. 2024. C# Dictionary with examples, 16 November 2023. [Online]. Avaialable at: https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/ [Accessed 20 May 2024].
 Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. Berkeley: Apress
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PROG6221_POE_Part2.Classes
{
    public class RecipeManager
    {
        // Dictionary to store recipes. (Geeksforgeeks, 2024).
        private Dictionary<string, RecipeDescription> recipe = new Dictionary<string, RecipeDescription>();

        // Delegate function for total calories. (Dotnetforall. 2024).
        public delegate void TotalCaloriesHandler(string name, int total);

        // Event for total calories. (Dotnetforall. 2024).
        public event TotalCaloriesHandler TotalCaloriesExceeded;

        //------------------------------------------------------------------------------------------------------------------------//

        // Function to check if the total calories of a recipe exceed 300. (Dotnetforall. 2024).
        public void CheckTotalCalories(string name)
        {
            Console.WriteLine("vdsvsdv");
            if (recipe.ContainsKey(name))
            {
                int total = 0;
                foreach (var ingredient in recipe[name].Ingredients)
                {
                    total += ingredient.Calories;
                    Console.WriteLine($"Recipe: {name}, Total Calories: {total}");
                }

                if ((total > 300))
                {
                    TotalCaloriesExceeded(name, total);
                }
            }
            else
            {
                Console.WriteLine("Help");
            }
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Funtion to add a new recipe according to its name. (Geeksforgeeks, 2024).
        public void AddNewRecipe(string name)
        {
            // Checks recipe dictionary for the name and adds new one if name not found. (Geeksforgeeks, 2024).
            if (!recipe.ContainsKey(name))
            {
                recipe[name] = new RecipeDescription();
            }
            else
            {
                // Error message if name already exists in recipe dictionary. (Geeksforgeeks, 2024).
                Console.WriteLine($"{name} already exists. Could not add");
            }
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Add new RecipeIngredients to recipe dictionary. (Geeksforgeeks, 2024).
        public void AddIngredients(string name, RecipeIngredients ingredient)
        {
            // If recipe name found, add new ingredients. (Geeksforgeeks, 2024).
            if (recipe.ContainsKey(name))
            {
                recipe[name].Ingredients.Add(ingredient);
            }
            else
            {
                // Error message if recipe could not be found. (Geeksforgeeks, 2024).
                Console.WriteLine($"{name}could not be found.");
            }
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Add new RecipeSteps to recipe dictionary. (Geeksforgeeks, 2024).
        public void AddSteps(string name, RecipeSteps step)
        {
            // If recipe name found, add new steps. (Geeksforgeeks, 2024).
            if (recipe.ContainsKey(name))
            {
                recipe[name].Steps.Add(step);
            }
            else
            {
                // Error message if recipe could not be found. (Geeksforgeeks, 2024).
                Functions.displayError($"{name}could not be found.");
            }
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Find a recipe based on it's name. (Geeksforgeeks, 2024).
        public void displayRecipe(string name)
        {
            // If recipe found. (Geeksforgeeks, 2024).
            if (recipe.ContainsKey(name))
            {                             
                Functions.menuHead(name);
                Console.WriteLine("Ingredients:");
                foreach (var item in recipe[name].Ingredients)
                {
                    Console.WriteLine($"{item.Quantity} {item.UnitType} of {item.Name}. Food Group: {item.FoodGroup}. Calories: {item.Calories}");
                }
                Console.WriteLine("Steps:");
                foreach (var step in recipe[name].Steps)
                {
                    Console.WriteLine($"Step {step.Position}: {step.Description}");
                }
            }
            else
            {
                // Error message if recipe could not be found. (Geeksforgeeks, 2024).
                Functions.displayError($"{name}could not be found.");
               
            }
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Sort and display recipes by alphabetically. (Geeksforgeeks, 2024).
        public void sortRecipes()
        {
            int pos = 1;

            var sortedRecipes = recipe.OrderBy(r => r.Key);
            foreach (var recipe in sortedRecipes)
            {
                Console.WriteLine($"[{pos}] : {recipe.Key}");
                pos++;
            }          
           
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Find a recipe based on its position. (Stackoverflow, 2024).
        public void findRecipe(int pos)
        {
            Console.WriteLine("Entered Loop");

            // Sort dictionary and turn into list. (Stackoverflow, 2024).
            var sortedKeys = recipe.Keys.OrderBy(k => k).ToList();

            if((pos > 0) && (pos < sortedKeys.Count))
            {
                string recipeName = sortedKeys[pos];
                displayRecipe(recipeName);
            }
            else
            {
                Functions.displayError("Invalid Range");
            }

        }


    }
}
//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//
