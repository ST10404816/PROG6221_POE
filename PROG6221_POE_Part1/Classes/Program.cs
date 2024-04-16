/*
 PROG6221 POE Part 1
ST10404816
Lisha Naidoo
Cape Town Campus
Group 1
 */

//Main Class
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace PROG6221_POE_Part1.Classes
{
	class Program
	{

		static void Main(string[] args)
		{

			//Recipe App
			Console.WriteLine("---------------------------------\n****** Recipe Application ******\n---------------------------------");
			//(Troelsen & Japikse, 2021).

			//Capture recipe name
			Console.Write("\nEnter the recipe name: ");
			string recipeName = Console.ReadLine();
			//(Troelsen & Japikse, 2021).

			//Captures number of ingredients
			Console.Write("\nEnter the number of ingredients: ");
			int numOfIngredients = Convert.ToInt32(Console.ReadLine());
			//(Troelsen & Japikse, 2021).

			//Captures number of steps of the recipe
			Console.Write("\nEnter the number of steps for the recipe: ");
			int numOfSteps = Convert.ToInt32(Console.ReadLine());
			//(Troelsen & Japikse, 2021).

			//Declares an object of Recipe Class
			Recipe recipe = new Recipe(recipeName, numOfIngredients, numOfSteps);
			//(Troelsen & Japikse, 2021).

			createRecipe(numOfIngredients, numOfSteps, recipeName, recipe);

			//Receives input from user
			userRecipeInput(recipe);
			//(Troelsen & Japikse, 2021).

		}

		//Method to ask user if they wish to create a recipe
		public static void userRecipeInput(Recipe recipe)
		{
			Console.WriteLine("---------------------------------\n****** Recipe Application ******\n---------------------------------");
			Console.Write("\n1)  Upscale ingredient quantity\n2)  Display recipe\n3)  Erease recipe data\n4)  Create a new recipe\n5)  Exit application\n\n---------------------------------\nChoose an option: ");
			int choice = Convert.ToInt32(Console.ReadLine());
			//Number menu
			switch (choice)
			{
				//Upscale ingredient quantity
				case 1:
					Console.Write("\nPlease enter a factor to multiply the ingredient's quantity by: ");
					int factor = Convert.ToInt32(Console.ReadLine());
					recipe.upscaleIngredientQuantity(factor);
					Console.WriteLine("\nIngredient quantities have been updated, Displaying updated recipe:\n---------------------------------");
					recipe.displayRecipe();
					Console.Write("\nWould you like to reset ingredient quantities to original values? y/n: ");
					string original = Console.ReadLine();
					if (original == "y")
					{
						recipe.revertIngredientQuantity(factor);
						Console.WriteLine("\n...Ingredient values have been reverted to original values...");
						recipe.displayRecipe();
					}
					userRecipeInput(recipe);
					break;
				//(Troelsen & Japikse, 2021).

				//Display recipe
				case 2:
					recipe.displayRecipe();
					userRecipeInput(recipe);
					break;
				//(Troelsen & Japikse, 2021).

				//Delete recipe
				case 3:
					Console.Write("\nAre you sure you want to erase Recipe data y/n?: ");
					string k = Console.ReadLine();
					if(k == "y")
					{
						recipe.clearRecipe();
						Console.WriteLine("\n...Recipe data has been erased...");
					}
					else
					{
						Console.WriteLine("\nRecipe data will not be erased.");
					}
					
					userRecipeInput(recipe);
					break;
				//(Troelsen & Japikse, 2021).

				//New recipe
				case 4:
					//Capture recipe name
					Console.Write("\nEnter the recipe name: ");
					string recipeName = Console.ReadLine();
					//(Troelsen & Japikse, 2021).

					//Captures number of ingredients
					Console.Write("\nEnter the number of ingredients: ");
					int numOfIngredients = Convert.ToInt32(Console.ReadLine());
					//(Troelsen & Japikse, 2021).

					//Captures number of steps of the recipe
					Console.Write("\nEnter the number of steps for the recipe: ");
					int numOfSteps = Convert.ToInt32(Console.ReadLine());
					//(Troelsen & Japikse, 2021).

					//Declares an object of Recipe Class
					recipe = new Recipe(recipeName, numOfIngredients, numOfSteps);
					//(Troelsen & Japikse, 2021).

					createRecipe(numOfIngredients, numOfSteps, recipeName, recipe);
					userRecipeInput(recipe);
					break;
				//(Troelsen & Japikse, 2021).

				//Terminate recipe application
				case 5:
					Console.WriteLine("\nApplication terminating...\n---------------------------------");
					Environment.Exit(0);
					break;
				//(Troelsen & Japikse, 2021).

				//Invalid response
				default:
					Console.WriteLine("\n***************************\nInvalid Response!\n***************************\nPlease try again...");
					userRecipeInput(recipe);
					break;
				//(Troelsen & Japikse, 2021).
			}

		}
		

		//Method to create new recipe
		public static void createRecipe(int numOfIngredients, int numOfSteps, string recipeName, Recipe recipe)
		{
		
			//Captures recipe data
			recordIngredients(numOfIngredients, recipe);
			recordRecipeSteps(numOfSteps, recipe);
			//(Troelsen & Japikse, 2021).

			//Display the recipe
			Console.WriteLine("\nRecipe: " + recipeName + "\n---------------------------------\n---------------------------------");
			recipe.displayRecipe();
			//(Troelsen & Japikse, 2021).

		}
		//(Troelsen & Japikse, 2021).

		//Method to capture ingredients
		public static void recordIngredients(int numOfIngredients, Recipe recipe)
		{
			Console.WriteLine("\n\n...Recording Recipe Ingredients...");

			for (int i = 0; i < numOfIngredients; i++)
			{
				//Captures ingredient data entered by user
				Console.Write("\nEnter the name of ingredient no. " + (i + 1) + ": ");
				string name = Console.ReadLine();
				Console.Write("\nEnter the unit of measurement for " + name + ": ");
				string unit = Console.ReadLine();
				Console.Write("\nEnter the qauntity of " + name + " to be used: ");
				int quantity = Convert.ToInt32(Console.ReadLine());
				//(Troelsen & Japikse, 2021).

				//Records data into arrays
				recipe.captureIngredients(name, unit, quantity, i);
				//(Troelsen & Japikse, 2021).
			}
		}
		//(Troelsen & Japikse, 2021).

		//Method to capture recipe steps
		public static void recordRecipeSteps(int numOfSteps, Recipe recipe)
		{
			Console.WriteLine("\n\n...Recording Recipe Steps...");

			for (int i = 0; i < numOfSteps; i++)
			{
				//Captures recipe step data entered by user
				Console.Write("\nEnter the description for step " + (i + 1) + ": ");
				string description = Console.ReadLine();
				//(Troelsen & Japikse, 2021).

				//Records data into an array
				recipe.captureStepDescription(description, i);
				//(Troelsen & Japikse, 2021).
			}

		}
		//(Troelsen & Japikse, 2021).

	}

}

/*
 References

Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. New York: Apress.
 
 */