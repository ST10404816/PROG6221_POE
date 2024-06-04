// Lisha Naidoo
// ST10404816
// Group 1

/*
 References

 Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. Berkeley: Apress
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Part2.Classes
{
    public class RecipeSteps
    {
        // Position of the recipe step. (Troelsen & Japikse, 2021).
        public int Position { get; }

        // Description stores the description the of steps in the recipe. (Troelsen & Japikse, 2021).
        public string Description { get; }

        //------------------------------------------------------------------------------------------------------------------------//

        // Constructor to add values to class. (Troelsen & Japikse, 2021).
        public RecipeSteps(int Position, string Description)
        {
            this.Position = Position;
            this.Description = Description;
        }

    }
}

//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//
