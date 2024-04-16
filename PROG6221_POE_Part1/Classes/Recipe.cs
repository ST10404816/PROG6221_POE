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

		//Method to display recipe
		public void displayRecipe()
		{
			if (numOfSteps == 0)
			{
				Console.WriteLine("\nThere is no recipe to display.\n");
			}
			else
			{
				//Displays the list of ingredients
				Console.WriteLine("***List of Ingredients***\n");
				for (int i = 0; i < numOfIngredients; i++)
				{
					Console.WriteLine(returnIngredient(i));
				}
				//(Troelsen & Japikse, 2021).

				//Displays the recipe steps
				Console.WriteLine("***Recipe Steps***\n");
				for (int i = 0; i < numOfSteps; i++)
				{
					Console.WriteLine(returnStepDescription(i));
				}
				Console.WriteLine();
			}
			//(Troelsen & Japikse, 2021).
		}
		//(Troelsen & Japikse, 2021).

		//Method to upscale ingredient quantity by a factor
		public void upscaleIngredientQuantity(int factor)
		{
			for (int i = 0; i < numOfIngredients; i++)
			{
				quantity[i] *= factor;
			}
		}
		//(Troelsen & Japikse, 2021).

		//Method to reverts ingredient quantity back to original value
		public void revertIngredientQuantity(int factor)
		{
			for (int i = 0; i < numOfIngredients; i++)
			{
				quantity[i] /= factor;
			}
		}
		//(Troelsen & Japikse, 2021).

		//Method to capture data of ingredients
		public void captureIngredients(string name, string unitOfMeasurement, int q, int position)
		{
			ingredientName[position] = name;
			quantity[position] = q;
			measurementUnit[position] = unitOfMeasurement;
		}
		//(Troelsen & Japikse, 2021).

		//Method to retrieve data of ingredients
		public string returnIngredient(int position)
		{
			return ("o "+ingredientName[position] +": " + quantity[position] +" "+ measurementUnit[position] );
		}
		//(Troelsen & Japikse, 2021).

		//Method to record recipe steps
		public void captureStepDescription(string description, int position)
		{
			stepDescription[position] = description;
		}
		//(Troelsen & Japikse, 2021).

		//Method to retrieve recipe steps
		public string returnStepDescription(int position)
		{
			return ("Step " + (position+1) + ": " + stepDescription[position]);
		}
		//(Troelsen & Japikse, 2021).

		//Method to delete recipe
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
