// Lisha Naidoo
// ST10404816
// Group 1

/*
 References

  Dotnetforall. 2024. Create and Invoke C# Delegate, 5 July 2019. [Online]. Avaialable at: https://www.dotnetforall.com/create-and-invoke-csharp-delegate/ [Accessed 25 May 2024].
  Dotnetpearls. 2024. Padleft, 4 January 2024. [Online]. Available at: https://www.dotnetperls.com/padright [Accessed 29 May 2024].
  Hart, B., C. 2024. Building a Menu-Driven Console Application in C#, CodeProject, 11 May 2024. [Blog]. Available at: https://www.codeproject.com/Articles/5382189/Building-a-Menu-Driven-Console-Application-in-Csha [Accessed 20 May 2024]. 
  Kumar, M. 2023. C# Naming Conventions, C-sharp Corner, 8 June 2023. [Blog]. Available at: https://www.c-sharpcorner.com/UploadFile/8a67c0/C-Sharp-coding-standards-and-naming-conventions/ [Accessed 20 May 2024]. 
  Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. Berkeley: Apress
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Part2.Classes.Recipe
{
    public class FoodGroup
    {
        // Dictionary that stores the Food Groups. (Geeksforgeeks, 2024).
        Dictionary<int, string> foodgroup = new Dictionary<int, string>()
        {
            // Adding Food Group name to dictionary. (Geeksforgeeks, 2024).
            {1, "Starchy Foods"},
            {2, "Vegetables and Fruits"},
            {3, "Legumes"},
            {4, "Proteins"},
            {5, "Dairy"},
            {6, "Fats and oils"},
            {7, "Water"}
            // (Sweetlife, 2024).
        };

        //------------------------------------------------------------------------------------------------------------------------//

        // Enum stores Food Group display information. (Microsoft, 2024).
        public enum FoodGroupDisplay
        {
            // Starchy Foods. (Sweetlife, 2024).
            [Description("Starchy Foods: Pap, Rice.")]
            StarchyFoods,
            // Vegetabes and Fruit. (Sweetlife, 2024).
            [Description("Vegetables and Fruits: Apricots, Lettuce.")]
            VegetablesAndFruits,
            // Legumes. (Sweetlife, 2024).
            [Description("Legumes: Beans, Peas, Lentils, Soya.")]
            Legumes,
            // Proteins. (Sweetlife, 2024).
            [Description("Proteins: Eggs, Meat, Chicken and Fish.")]
            Proteins,
            // Dairy. (Sweetlife, 2024).
            [Description("Dairy: Milk, Nuts, Cheese, Yoghurt. ")]
            Dairy,
            // Fats and Oils. (Sweetlife, 2024).
            [Description("Fats and Oils: Avacado, olive oil. ")]
            FatsAndOils,
            // Legumes. (Sweetlife, 2024).
            [Description("Aim for 6 to 8 glasses of water each day. ")]
            Water,
            // Unknown value. (Hart, 2024).
            [Description("Unknown")]
            Unknown
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Function to display the food group. (Hart, 2024).
        public static void Display()
        {
            //Application Welcome Line. (Troelsen & Japikse, 2021).
            Console.WriteLine($"Food Groups");

            // Int that stores menu items. (Troelsen & Japikse, 2021).
            var itemNumber = 1;

            // An object named check will retrieve all the menu items using a foreach loop. (Hart, 2024).
            foreach (FoodGroupDisplay check in Enum.GetValues(typeof(FoodGroupDisplay)))

                // The if statement checks to if check is not Unknown. (Hart, 2024).
                if (check != FoodGroupDisplay.Unknown)
                {
                    // itemDescription stores the description received by the GetEnumDescription() method in MenuFunctions. (Hart, 2024). 
                    var itemDescription = FoodGroup.getDescription(check);

                    //A menu item is displayed based on it's position stored in itemNumber. (Hart, 2024).
                    Console.WriteLine($"[{itemNumber}]: {itemDescription.PadRight(40)}");

                    // itemNumber increases each time the loop executes. (Hart, 2024).
                    itemNumber++;
                }

        }

        //------------------------------------------------------------------------------------------------------------------------//

        private static string getDescription(Enum val)
        {
            // GetType() returns the type of val and GetField returns the Field Information. (Hart, 2024).
            var fieldInfo = val.GetType().GetField(val.ToString());
            // attribute will store the description associated with val. (Hart, 2024). 
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute));
            // The menu description will be returned but if it is null, val will be converted to a string. (Hart, 2024).
            return attribute == null ? val.ToString() : attribute.Description;

        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Function to retrieve the name of the food group. (Troelsen & Japikse, 2021).
        public string getFoodGroupName(int i)
        {
            foodgroup.TryGetValue(i, out string groupName);
            return groupName;
        }
    }
}

//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//
