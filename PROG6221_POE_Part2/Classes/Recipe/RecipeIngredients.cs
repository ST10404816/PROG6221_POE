// Lisha Naidoo
// ST10404816
// Group 1

/*
 References

 Stackoverflow. 2024. Proper way to initialize a C# dictionary with values, 23 January 2019. [SourceCode]. Available at: https://stackoverflow.com/questions/17047602/proper-way-to-initialize-a-c-sharp-dictionary-with-values [Accessed 20 May 2024].
 Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. Berkeley: Apress
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Part2.Classes
{
    public class RecipeIngredients
    {
        // Name stores the name of the ingredient needed for the recipe. (Troelsen & Japikse, 2021).
        public string Name;
        // UnitType stores the unit of measurement for the ingredient. (Troelsen & Japikse, 2021).
        public string UnitType { get; set; }
        // Quantity stores the quantity of a ingredient needed for the recipe. (Troelsen & Japikse, 2021).
        public int Quantity { get; set; }
        // Quantity stores the food group an ingredient belongs to. (Troelsen & Japikse, 2021).
        public string FoodGroup { get; set; }
        // Calories stores the amount of calories an ingredient has. (Troelsen & Japikse, 2021).
        public int Calories { get; set; }
        // TotalCalories stores the total amount of calories the recipe has. (Troelsen & Japikse, 2021).
        public int TotalCalories { get; set; }

//------------------------------------------------------------------------------------------------------------------------//

        // A constructor to add a new ingredients to the class. (Stackoverflow, 2024).
        public RecipeIngredients(string Name, string UnitType, int Quantity, string FoodGroup, int Calories)
        {
            // The ingredient values are saved according to the ingredient name. (Stackoverflow, 2024).
            this.Name = Name;
            this.UnitType = UnitType;
            this.Quantity = Quantity;
            this.FoodGroup = FoodGroup;
            this.Calories = Calories;

            // Adds new calories to calories total. (Troelsen & Japikse, 2021).          
            TotalCalories += this.Calories;

        }
    }
}

//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//