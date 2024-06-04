// Lisha Naidoo
// ST10404816
// Group 1

/*
 References

 Gahan, E. 2024. Enhancing Console Output With Underlining, Colors And More, C-Sharp Corner, 26 July 2018. [Online]. Available at: https://www.c-sharpcorner.com/article/enhancing-console-output-with-underlining-colors-and-more6/ [Accessed 27 May 2024]. 
 Geeksforgeeks. 2024. C# Dictionary with examples, 16 November 2023. [Online]. Avaialable at: https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/ [Accessed 20 May 2024].
 Grabthiscode. 2024. Q: how to change the title of the console in c#, 21 May 2021. [Online]. Available at: https://grabthiscode.com/csharp/how-to-change-the-title-of-the-console-in-c [Accessed 28 May 2024]
 Dotnetforall. 2024. Create and Invoke C# Delegate, 5 July 2019. [Online]. Avaialable at: https://www.dotnetforall.com/create-and-invoke-csharp-delegate/ [Accessed 25 May 2024].
 Geeksforgeeks. 2024. C# Dictionary with examples, 16 November 2023. [Online]. Avaialable at: https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/ [Accessed 20 May 2024].
 Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. Berkeley: Apress
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Part2.Classes
{
    internal class Functions
    {
        // A function to display error. (Troelsen & Japikse, 2021).
        public static void displayError(string errorMessage)
        {
            // Changes the console background colour to red and text-colour to black. (Gahan, 2024).
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            // Displays if the error message. (Dotnetforall. 2024).
            Console.WriteLine($"\r\n{errorMessage}\r\n");

            // Changes the console background and text colour back to original colours. (Gahan, 2024).
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // User must enter a key to continue. (Troelsen & Japikse, 2021).
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Console cleared for the next iteration. (Troelsen & Japikse, 2021).
            Console.Clear();
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // A function to display green message to accept user input. (Troelsen & Japikse, 2021).
        public static void displayGreen(string message)
        {
            // Changes the console background colour to green and the text-colour to white. (Gahan, 2024).
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;

            // Displays if the total calories are below 300. (Dotnetforall. 2024).
            Console.WriteLine($"\r\n{message}\r\n");

            // Changes the console background and text colour back to original colours. (Gahan, 2024).
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // User must enter a key to continue. (Troelsen & Japikse, 2021).
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Console cleared for the next iteration. (Troelsen & Japikse, 2021).
            Console.Clear();
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // A function to make sure the user enters an integer. (Troelsen & Japikse, 2021).
        public static int getInteger(string message)
        {
            // Integer that will be returned. (Troelsen & Japikse, 2021).
            int final = 0;

            // A counter to check the amount of times the user has made an error. (Troelsen & Japikse, 2021).
            int count = 0;

            // A variable that will end the loop if it is true. (Troelsen & Japikse, 2021).
            bool check = false;

            while (!check)
            {
                // Display the message passed to the function. (Troelsen & Japikse, 2021).
                Console.WriteLine(message);

                // Records input from the user. (Troelsen & Japikse, 2021).
                var input = Console.ReadLine();

                // The statement checks to see if the user inserted an integer. (Troelsen & Japikse, 2021).
                if (!int.TryParse(input, out final))
                {
 
                    // The user did not enter an integer. (Troelsen & Japikse, 2021). 
                    displayError($"Please enter a valid integer.");
                    count++;

                }
                else
                {
                    // The integer value from the user has been accepted. (Troelsen & Japikse, 2021).
                    check = true;
                    displayGreen($"The value {final} was accepted");
                }

            }

            // Returns the entered integer. (Troelsen & Japikse, 2021).
            return final;
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // A function to capitalize the first letter of a word. (Inspirnathan, 2024)
        public static string capitalizeString(string word)
        {
            return $"{char.ToUpper(word[0])}{word.Substring(1)}";
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Check to see if the user inputted the correct information. (Troelsen & Japikse, 2021).
        public static string checkUserInputString(string message)
        {
            // Display the message. (Troelsen & Japikse, 2021).
            Console.WriteLine(message);

            // Stores the user input. (Troelsen & Japikse, 2021).
            var input = Console.ReadLine();

            // Ask the user if they entered the correct information. (Troelsen & Japikse, 2021).
            Console.WriteLine($"Is {capitalizeString(input)} correct? (Y/N)");

            // Save the user response in confirmation. (Troelsen & Japikse, 2021).
            var confirmation = Console.ReadLine().ToUpper()[0];

            // String value to return users correct choice. (Troelsen & Japikse, 2021).
            var final = "";

            // Bool variable to store a value that wi determine wether the loop continues or not. (Troelsen & Japikse, 2021).
            bool endLoop = false;

            // Loop continues until endLoop is true. (Troelsen & Japikse, 2021).
            while (!endLoop)
            {
                // If the user inputs the option 'Y'. (Troelsen & Japikse, 2021).
                if (confirmation == 'Y')
                {
                    // The loop will end and the final string will be returned. (Troelsen & Japikse, 2021).
                    endLoop = true;
                    final = input;
                }
                // If the user inputs the option 'N'. (Troelsen & Japikse, 2021).
                else if (confirmation == 'N')
                {
                    // The previous instructions that led the user to this function will be repeated. (Troelsen & Japikse, 2021).
                    Console.WriteLine(message);

                    // The variable will store the users input. (Troelsen & Japikse, 2021).
                    input = Console.ReadLine();

                    // The user will be asked to confirm their input again. (Troelsen & Japikse, 2021).
                    Console.WriteLine($"Is {input} correct? (Y/N)");
                }
                // Default: If user input is not recognized. (Troelsen & Japikse, 2021).
                else
                {
                    displayError($"The value you entered was not recognized, Please try again");

                    // Asks the user to answer the initail question again. (Troelsen & Japikse, 2021).
                    Console.WriteLine($"Is {input} correct? (Y/N)");

                }
            }

            // A final string is returned after being accepted by the user. (Troelsen & Japikse, 2021).
            return final.ToString();
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // A function to display an instruction header in menus. (Troelsen & Japikse, 2021).
        public static void menuHead(string message)
        {
            // Clear the console display. (Dotnetpearls, 2024). 
            Console.Clear();

            // A line to be displayed in header. (Troelsen & Japikse, 2021).
            string line = "---------------------------------------";

            // Stores the screenwidth halved. (Dotnetpearls, 2024).
            int screenWidth = Console.WindowWidth / 2;

            // Stores half of the width of the line to be displayed. (Dotnetpearls, 2024).
            int lineWidth = line.Length / 2;

            // Stores message width halved. (Dotnetpearls, 2024).
            int messageWidth = message.Length / 2;

            // Displays the header. (Dotnetpearls, 2024).
            Console.WriteLine($"{line.PadLeft(screenWidth + lineWidth)}\r\n{message.PadLeft(screenWidth + messageWidth)}\r\n{line.PadLeft(screenWidth + lineWidth)}\r\n");

        }

    }
}

//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//

