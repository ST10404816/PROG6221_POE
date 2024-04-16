/*
 PROG6221 POE Part 1
ST10404816
Lisha Naidoo
Cape Town Campus
Group 1
 */

//Recipe Class
namespace PROG6221_POE_Part1.Classes
{
	internal class Recipe
	{
		//Variables
		private int numOfIngredients;
		private string [] ingredientName;
		private string [] measurementUnit;
		private int [] quantity;
		private int numOfSteps;
		private string [] stepDescription;
		//(Troelsen & Japikse, 2021).

		//Constructor {}
		public Recipe(string name, int i, int j)
		{
			numOfIngredients = i;
			ingredientName = new string[numOfIngredients];
			measurementUnit = new string[numOfIngredients]; 
			quantity = new int[numOfIngredients];
			numOfSteps = j;
			stepDescription = new string[numOfSteps];
		}
		//(Troelsen & Japikse, 2021).

		//------------------------------------------------ Display Recipe ------------------------------------------------//
		public void displayRecipe()
		{
			if (numOfSteps == 0)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("\nThere is no recipe to display.\n");
				Console.ForegroundColor = ConsoleColor.White;
			}
			else
			{
				//Displays the list of ingredients
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine("\n***List of Ingredients***\n");
				Console.ForegroundColor = ConsoleColor.Black;
				Console.BackgroundColor = ConsoleColor.Yellow;
				for (int i = 0; i < numOfIngredients; i++)
				{
					Console.WriteLine(returnIngredient(i));
				}
				Console.BackgroundColor = ConsoleColor.Black;
				Console.ForegroundColor = ConsoleColor.White;

				//Displays the recipe steps
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("\n***Recipe Steps***\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.WriteLine();
				for (int i = 0; i < numOfSteps; i++)
				{
					Console.WriteLine(returnStepDescription(i));
				}
				Console.BackgroundColor = ConsoleColor.Black;
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine();
			}
			//(Troelsen & Japikse, 2021).
		}
		//(Troelsen & Japikse, 2021).

		//------------------------------------------------ Upscale Ingredient Quantity Method ------------------------------------------------//
		public void upscaleIngredientQuantity(int factor)
		{
			for (int i = 0; i < numOfIngredients; i++)
			{
				quantity[i] *= factor;
			}
		}
		//(Troelsen & Japikse, 2021).

		//------------------------------------------------ Revert quantity to original data ------------------------------------------------//
		public void revertIngredientQuantity(int factor)
		{
			for (int i = 0; i < numOfIngredients; i++)
			{
				quantity[i] /= factor;
			}
		}
		//(Troelsen & Japikse, 2021).

		//------------------------------------------------ Capture Ingredient data ------------------------------------------------//
		public void captureIngredients(string name, string unitOfMeasurement, int q, int position)
		{
			ingredientName[position] = name;
			quantity[position] = q;
			measurementUnit[position] = unitOfMeasurement;
		}
		//(Troelsen & Japikse, 2021).

		//------------------------------------------------ Return string of Ingredients data ------------------------------------------------//
		public string returnIngredient(int position)
		{
			return ("- " + quantity[position] + " " + measurementUnit[position] + " of " + ingredientName[position]);
		}
		//(Troelsen & Japikse, 2021).

		//------------------------------------------------ Capture Recipe steps ------------------------------------------------//
		public void captureStepDescription(string description, int position)
		{
			stepDescription[position] = description;
		}
		//(Troelsen & Japikse, 2021).

		//------------------------------------------------ Display Recipe Stpes ------------------------------------------------//
		public string returnStepDescription(int position)
		{
			return ("Step " + (position+1) + ": " + stepDescription[position]);
		}
		//(Troelsen & Japikse, 2021).

		//------------------------------------------------ Clear Recipe ------------------------------------------------//
		public void clearRecipe()
		{
			numOfIngredients = 0;
			numOfSteps = 0;
			Array.Clear(ingredientName);
			Array.Clear(measurementUnit);
			Array.Clear(quantity);
			Array.Clear(stepDescription);
		}
		//(Troelsen & Japikse, 2021).

		//Destructor ~{}
		~Recipe()
		{
			clearRecipe();
		}
		//(Troelsen & Japikse, 2021).

	}
}

/*
 References

Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. New York: Apress.
 
 */
