// Lisha Naidoo
// ST10404816
// Group 1

/*
 References

 Thangarasu, A. 2021. How to create C# List<T> generics, Dev.to, 5 February 2021. [Blog]. Available at: https://dev.to/ajeetht/how-to-create-c-list-t-generics-hkk [Accessed 20 May 2024]. 
 Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. Berkeley: Apress
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Part2.Classes
{
    public class RecipeDescription
    {
        // A List to store Recipe Ingredients. (Thangarasu, 2021).
        public List<RecipeIngredients> Ingredients { get; set; } = new List<RecipeIngredients>();

        // A List to store Steps of the Recipe. (Thangarasu, 2021).
        public List<RecipeSteps> Steps { get; set; } = new List<RecipeSteps>();

    }
}

//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//
