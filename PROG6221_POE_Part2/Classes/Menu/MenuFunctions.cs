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

namespace PROG6221_POE_Part2.Classes.Menu
{
    public class MenuFunctions
    {
        // Getter methods. (Troelsen & Japikse, 2021).
        public static void getDisplay()
        {
            // A method to display the menu. (Troelsen & Japikse, 2021).
            Display();
        }

        //------------------------------------------------------------------------------------------------------------------------//


        public static MenuDescription.DisplayMenu getUserChoice()
        {
            // A method to get the user's choice. (Troelsen & Japikse, 2021).
            return UserChoice();
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // A method to display the menu. (Hart, 2024).
        private static void Display()
        {
          
            // Changes the console output screen color and text. (Dotnetforall. 2024).
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            // Center the text. (Dotnetpearls, 2024).
            string line = "---------------------------------------";
            string message = "Welcome to the Recipe App";
            int screenWidth = Console.WindowWidth / 2;
            int messageWidth = message.Length / 2;
            int lineWidth = line.Length / 2;
            Console.WriteLine(line.PadLeft(screenWidth + lineWidth));
            Console.WriteLine(message.PadLeft(screenWidth + messageWidth));
            Console.WriteLine(line.PadLeft(screenWidth + lineWidth));
            Console.WriteLine(" ");

            // The instruction displayed on the menu. (Troelsen & Japikse, 2021).
            Console.WriteLine("Choose an option:\n");

            // Avariable that stores the number of the item on the menu. (Troelsen & Japikse, 2021).
            var itemNumber = 1;

            // A DisplayMenu object named userChoice will retrieve all the menu items using a foreach loop. (Hart, 2024).
            foreach (MenuDescription.DisplayMenu check in Enum.GetValues(typeof(MenuDescription.DisplayMenu)))

                // The if statement checks to if check is not Unknown. (Hart, 2024).
                if (check != MenuDescription.DisplayMenu.Unknown)
                {
                    // itemDescription stores the description received by the GetEnumDescription() method in MenuFunctions. (Hart, 2024). 
                    var itemDescription = MenuFunctions.EnumDescription(check);

                    //A menu item is displayed based on it's position stored in itemNumber. (Hart, 2024).
                    Console.WriteLine($"[{itemNumber}]: {itemDescription}");

                    // itemNumber increases each time the loop executes. (Hart, 2024).
                    itemNumber++;
                }

            // After the full menu is displayed, the user can make a choice. (Troelsen & Japikse, 2021). 
            Console.Write("\nEnter your selection: ");
        }

        //------------------------------------------------------------------------------------------------------------------------//


        // This method will retrieve the user's input. (Hart, 2024).
        private static MenuDescription.DisplayMenu UserChoice()
        {
            // userInput stores the value entered by the user. (Troelsen & Japikse, 2021). 
            var userInput = Console.ReadLine();
            // Value will be passed into DisplayMenu. (Troelsen & Japikse, 2021).
            return Enum.TryParse(userInput, out MenuDescription.DisplayMenu choice)
            // If the value cannot be passed, choice will become the default which is Unknown. (Hart, 2024).
            ? choice : MenuDescription.DisplayMenu.Unknown;
        }

        //------------------------------------------------------------------------------------------------------------------------//


        // This method will return a description from DisplayMenu based on the enum value. (Hart, 2024).
        private static string EnumDescription(Enum val)
        {
            // GetType() returns the type of val and GetField returns the Field Information. (Hart, 2024).
            var fieldInfo = val.GetType().GetField(val.ToString());
            // attribute will store the description associated with val. (Hart, 2024). 
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute));
            // The menu description will be returned but if it is null, val will be converted to a string. (Hart, 2024).
            return attribute == null ? val.ToString() : attribute.Description;

        }
    }

   
}

//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//

