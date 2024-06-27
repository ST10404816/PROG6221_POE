// Lisha Naidoo
// ST10404816
// Group 1

// References:
// Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. Berkeley: Apress

using System.Collections.Generic;

namespace RecipeApp
{
    // Class to store ingredients (Troelsen & Japikse, 2021).
    public class Ingredient
    {
        // Stores the name of the ingredient (Troelsen & Japikse, 2021).
        public string Name { get; set; }
        // Stores Ingredient quantity (Troelsen & Japikse, 2021).
        public double Quantity { get; set; }
        // Stores Ingredient unit (Troelsen & Japikse, 2021).
        public string Unit { get; set; }
        // Stores Ingredient calorie count (Troelsen & Japikse, 2021).
        public int Calories { get; set; }
        // Stores the food-group the Ingredient belongs to (Troelsen & Japikse, 2021).
        public string FoodGroup { get; set; }
    }

    //------------------------------------------------------------------------------------------------------------------------//

    // Class to store recipes (Troelsen & Japikse, 2021).
    public class Recipe
    {
        // Stores Recipe name (Troelsen & Japikse, 2021).
        public string Name { get; set; }
        // A List to store recipe ingredients (Troelsen & Japikse, 2021).
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        // A List to store recipe steps (Troelsen & Japikse, 2021).
        public List<string> Steps { get; set; } = new List<string>();
    }
}

//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//

