// Lisha Naidoo
// ST10404816
// Group 1

/*
 References

 Hart, B., C. 2024. Building a Menu-Driven Console Application in C#, CodeProject, 11 May 2024. [Blog]. Available at: https://www.codeproject.com/Articles/5382189/Building-a-Menu-Driven-Console-Application-in-Csha [Accessed 20 May 2024]. 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Part2.Classes
{
    public class MenuDescription
    {
        // Menu choices for the recipe app
        public enum DisplayMenu
        {
            // This option will allow the user to insert a new recipe. (Hart, 2024).
            [Description("View Recipes")]
            ViewRecipes,

            // This option will allow the user to view all the recipes stored. (Hart, 2024).
            [Description("Insert Recipe")]
            InsertRecipe,

            // This option will allow the user to exit the app. (Hart, 2024).
            [Description("Exit")]
            Exit,

            // This option will be returned if the user's input cannot be passed to enum. (Hart, 2024).
            [Description("Unknown")]
            Unknown

        }
       
    }
}

//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//

