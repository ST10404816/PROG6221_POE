// Lisha Naidoo
// ST10404816
// Group 1

/*
 References

 Grabthiscode. 2024. Q: how to change the title of the console in c#, 21 May 2021. [Online]. Available at: https://grabthiscode.com/csharp/how-to-change-the-title-of-the-console-in-c [Accessed 28 May 2024].
 Hart, B., C. 2024. Building a Menu-Driven Console Application in C#, CodeProject, 11 May 2024. [Blog]. Available at: https://www.codeproject.com/Articles/5382189/Building-a-Menu-Driven-Console-Application-in-Csha [Accessed 20 May 2024]. 

 Stackoverflow. 2024. Proper way to initialize a C# dictionary with values, 23 January 2019. [SourceCode]. Available at: https://stackoverflow.com/questions/17047602/proper-way-to-initialize-a-c-sharp-dictionary-with-values [Accessed 20 May 2024].
 Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. Berkeley: Apress
 */

using PROG6221_POE_Part2.Classes;
using PROG6221_POE_Part2.Classes.Menu;
using PROG6221_POE_Part2.Classes.Recipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Change console title. (Grabthiscode, 2024).
            Console.Title = "Sanele's Recipe App";

            RecipeManager recipeManager = new RecipeManager();
            MenuFunctions menuFunctions = new MenuFunctions();

            recipeManager.AddNewRecipe("Pancakes"); 
            for(int i=0; i< 10; i++)
            {
                recipeManager.AddIngredients("Pancakes", new RecipeIngredients("Flour", "Cups", 2, "Carbohydrates", 20));
                recipeManager.AddSteps("Pancakes", new RecipeSteps(2, "Add the wet ingredients and stir."));
            }          
            recipeManager.AddNewRecipe("Cupcakes");
            for (int i = 0; i < 10; i++)
            {
                recipeManager.AddIngredients("Cupcakes", new RecipeIngredients("Flour", "Cups", 2, "Carbohydrates", 20));
                recipeManager.AddSteps("Cupcakes", new RecipeSteps(2, "Add the wet ingredients and stir."));
            }
            recipeManager.AddNewRecipe("Lotus");
            for (int i = 0; i < 10; i++)
            {
                recipeManager.AddIngredients("Lotus", new RecipeIngredients("Flour", "Cups", 2, "Carbohydrates", 20));
                recipeManager.AddSteps("Lotus", new RecipeSteps(2, "Add the wet ingredients and stir."));
            }
            recipeManager.AddNewRecipe("Guv");
            for (int i = 0; i < 10; i++)
            {
                recipeManager.AddIngredients("Guv", new RecipeIngredients("Flour", "Cups", 2, "Carbohydrates", 20));
                recipeManager.AddSteps("Guv", new RecipeSteps(2, "Add the wet ingredients and stir."));
            }
            recipeManager.AddNewRecipe("ddede");
            for (int i = 0; i < 10; i++)
            {
                recipeManager.AddIngredients("ddede", new RecipeIngredients("Flour", "Cups", 2, "Carbohydrates", 20));
                recipeManager.AddSteps("ddede", new RecipeSteps(2, "Add the wet ingredients and stir."));
            }
            
            while (true)
            {
                MenuFunctions.getDisplay();
                var choice = MenuFunctions.getUserChoice();

                // Convert 1-based menu choice to 0-based index (Hart, 2024).
                var choiceIndex = (int)choice - 1;

                // Check if choice is within the valid range (Hart, 2024).
                if (choiceIndex >= 0 && choiceIndex < Enum.GetValues(typeof(MenuDescription.DisplayMenu)).Length) // Check against all menu items
                    // Perform action based on user choice index (Hart, 2024).
                    switch (choiceIndex)
                    {
                        // Function to display recipes. (Troelsen & Japikse, 2021).
                        case (int)MenuDescription.DisplayMenu.ViewRecipes:

                            // Determines wether the loop ends or not. (Troelsen & Japikse, 2021).
                            bool end = false;

                            // While loop will continue until user enters 0. (Troelsen & Japikse, 2021).
                            while (end == false)
                            {
                                // Header. (Troelsen & Japikse, 2021).
                                Functions.menuHead("Recipes List");

                                // Calls a function from RecipeManager to sort recipes. (Troelsen & Japikse, 2021).
                                recipeManager.sortRecipes();

                                // Calls a function to ask the user to insert an integer. (Troelsen & Japikse, 2021).
                                int pos = Functions.getInteger("Enter recipe number to view (Enter 0 to go back): ");                               
                                if (pos == 0)
                                {
                                    // Ends loop. (Troelsen & Japikse, 2021).
                                    end = true;
                                    break;
                                }
                                else
                                {
                                    // Displays the recipe chosen by the user. (Troelsen & Japikse, 2021).
                                    recipeManager.findRecipe(pos - 1);
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                }

                            }
                            
                            break;
                        

                        case (int)MenuDescription.DisplayMenu.InsertRecipe:

                            // Header. (Troelsen & Japikse, 2021).
                            Functions.menuHead("Insert a recipe");

                            // Saves the recipe name. (Troelsen & Japikse, 2021).
                            Console.Write("Enter a name for the recipe: ");
                            string recipeName = Console.ReadLine();
                            recipeManager.AddNewRecipe(recipeName);

                            Console.Write("\nEnter the number of ingredients: ");
                            int numOfIngredients = 0;
                            string s = Console.ReadLine();
                            while (!int.TryParse(s, out numOfIngredients))
                            {
                                Console.Write("\nPlease enter a valid number: ");
                                s = Console.ReadLine();
                            }
                            
                            for (int i = 0; i < numOfIngredients; i++)
                            {
                                Console.WriteLine("\n\n...Recording Ingredients...");


                                FoodGroup.Display();
                                //Captures ingredient data entered by user
                                Console.Write("\nEnter the name of ingredient no. " + (i + 1) + ": ");
                                string name = Console.ReadLine();
                                Console.Write("\nEnter the unit of measurement for " + name + ": ");
                                string unit = Console.ReadLine();
                                Console.Write("\nEnter the qauntity of " + name + " to be used: ");
                                int quantity = Convert.ToInt32(Console.ReadLine());
                                Console.Write("\nEnter the food group " + name + ": ");
                                string foodGroup = Console.ReadLine();
                                Console.Write("\nEnter the calories of " + name + " to be used: ");
                                int calories = Convert.ToInt32(Console.ReadLine());
                                recipeManager.AddIngredients(recipeName, new RecipeIngredients(name, unit, quantity, foodGroup, calories));
                               
                                //(Troelsen & Japikse, 2021).

                            }
                            Console.Write("\nEnter the number of steps for the recipe: ");
                            int numOfSteps = 0;
                            s = Console.ReadLine();
                            while (!int.TryParse(s, out numOfSteps))
                            {
                                Console.Write("\nPlease enter a valid number: ");
                                s = Console.ReadLine();
                            }

                            Console.WriteLine("\n\n...Recording Recipe Steps...");

                            for (int i = 0; i < numOfSteps; i++)
                            {
                                //Captures recipe step data entered by user
                                Console.Write("\nEnter the description for step " + (i + 1) + ": ");
                                string description = Console.ReadLine();
                                recipeManager.AddSteps(recipeName, new RecipeSteps(i, description));
                                //(Troelsen & Japikse, 2021).


                            }





                            break;

                        case (int)MenuDescription.DisplayMenu.Exit:
                            Console.Write(
                                "Are you sure you want to exit the application? (Y/N): "
                            );
                            var confirmation = Console.ReadLine().ToUpper()[0];
                            Console.WriteLine();
                            if (confirmation == 'Y')
                            {
                                Console.WriteLine("Exiting the application...");
                                return; // Exit the Main method (Hart, 2024).
                            }

                            Console.Clear();
                            continue;

                        default:
                            Console.WriteLine(
                                "Invalid choice. Please try again."
                            );
                            break;
                    }
                else
                    Console.WriteLine("Invalid choice. Please try again.");

                /*Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear(); // Clear the console for the next iteration (Hart, 2024).*/
            }
        }

        // Function to view all recipes in alpabetical order. (Stackoverflow, 2024).
        public void ViewRecipes()
        {
            Console.WriteLine("Sorted Recipes:");
            

        }

    }

}

//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//