***
***
\[PROG6221 POE Part 2\]
\[Lisha Naidoo\]
\[ST10404816\]
***
***

# \[Sanele's Recipe App\]

## Table of Contents
- Requirements
- Description
- Navigation
- Classes
- References

## Requirements

+ IDE: Visual Studio Community 2022
+ Language: C#
+ .NET Framework Version: .NET Framework 4.8

## Description

This a a console application created to store and retrieve recipes. Recipe details will be stored in generic collections and include the recipe name, ingredients and steps. For each ingredient, the food-group and calories can be added. Users will have options to upscale recipe ingredient quantities, display the recipe, erase recipe data, create a new recipe, or exit the application (Nyakundi, 2021).

## Navigation

### Menu options:
1. View Recipes
2. Insert Recipe
3. Exit
+ (Nyakundi, 2021).

**View Recipe**
A list of recipes will be displayed and the user will have the option to display recipe details by entering the name of the recipe (Troelsen & Japikse, 2021).

**Insert Recipe**
The user will have to enter the recipe name, ingredients and steps which will be recored in a new recipe (Troelsen & Japikse, 2021).
+ Recipe information: Name, ingredients, steps (Troelsen & Japikse, 2021).
+ Ingredients information: Number of ingredients, name, quauntity, unit of measurement, food group, calories (Troelsen & Japikse, 2021).
+ Steps information: Number of steps, description (Troelsen & Japikse, 2021).

## Classes
* RecipeSteps : Stores the steps of the recipe (Troelsen & Japikse, 2021).
* RecipeIngredients : Stores the ingredients of the recipe (Troelsen & Japikse, 2021).
* RecipeDescription : Stores lists of RecipeSteps and REcipeIngredients (Troelsen & Japikse, 2021). 
* RecipeManager : Stores RecipeSteps, RecipeIngredients and recipe name in a dictionary and contains functions and deligates for the main program. (Thangarasu, 2021).
* Program : Uses a dictionary of RecipeManager to store and retrieve recipes (Geeksforgeeks, 2024).

## References

- Dotnetforall. 2024. Create and Invoke C# Delegate, 5 July 2019. [Online]. Avaialable at: https://www.dotnetforall.com/create-and-invoke-csharp-delegate/ [Accessed 25 May 2024].
- Dotnetpearls. 2024. Padleft, 4 January 2024. [Online]. Available at: https://www.dotnetperls.com/padright [Accessed 29 May 2024].
- Gahan, E. 2024. Enhancing Console Output With Underlining, Colors And More, C-Sharp Corner, 26 July 2018. [Online]. Available at: https://www.c-sharpcorner.com/article/enhancing-console-output-with-underlining-colors-and-more6/ [Accessed 27 May 2024]. 
- Geeksforgeeks. 2024. C# Dictionary with examples, 16 November 2023. [Online]. Avaialable at: https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/ [Accessed 20 May 2024].
- Grabthiscode. 2024. Q: how to change the title of the console in c#, 21 May 2021. [Online]. Available at: https://grabthiscode.com/csharp/how-to-change-the-title-of-the-console-in-c [Accessed 28 May 2024].
- Hart, B., C. 2024. Building a Menu-Driven Console Application in C#, CodeProject, 11 May 2024. [Blog]. Available at: https://www.codeproject.com/Articles/5382189/Building-a-Menu-Driven-Console-Application-in-Csha [Accessed 20 May 2024]. 
- Inspirnathan. 2024. How To Capitalize The First Letter Of A String In C#, 9 May 2022. [Onine]. Available at: https://inspirnathan.com/posts/67-capitalize-first-letter-of-string-in-csharp [Accessed 24 May 2024].
- Kumar, M. 2023. C# Naming Conventions, C-sharp Corner, 8 June 2023. [Blog]. Available at: https://www.c-sharpcorner.com/UploadFile/8a67c0/C-Sharp-coding-standards-and-naming-conventions/ [Accessed 20 May 2024]. 
- Microsoft. 2024. Enumeration types (C# reference), 4 August 2023. [Online]. Available at: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum [Accessed 23 May 2024].
- Nyakundi, H. 2021. How to Write a Good README File for Your GitHub Project, freeCodeCamp.org, 8 December 2021. [Online]. Available at: https://www.freecodecamp.org/news/how-to-write-a-good-readme-file/ [Accessed 30 May 2024].
- Thangarasu, A. 2021. How to create C# List<T> generics, Dev.to, 5 February 2021. [Blog]. Available at: https://dev.to/ajeetht/how-to-create-c-list-t-generics-hkk [Accessed 20 May 2024]. 
- Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. Berkeley: Apress
- Stackoverflow. 2024. Proper way to initialize a C# dictionary with values, 23 January 2019. [SourceCode]. Available at: https://stackoverflow.com/questions/17047602/proper-way-to-initialize-a-c-sharp-dictionary-with-values [Accessed 20 May 2024].
- Sweetlife. 2024. What are the different food groups? A simple explanation, 23 November 2021. [Online]. Avaialable at: https://sweetlife.org.za/what-are-the-different-food-groups-a-simple-explanation/ [Accessed 22 May 2024].
