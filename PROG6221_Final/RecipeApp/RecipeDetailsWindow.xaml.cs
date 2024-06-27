// Lisha Naidoo
// st10404816
// Group 1

// References:
// Microsoft Learn. 2024. XAML overview (WPF .NET), 2 June 2023. [Online]. Available at: https://learn.microsoft.com/en-us/dotnet/desktop/wpf/xaml/?view=netdesktop-8.0 [Accessed 24 June 2024].
// Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. Berkeley: Apress.
// Walker, A. 2024. WPF Tutorial for Beginners: How to Create Application [Example], 24 February 2024. [Online]. Available at: https://www.guru99.com/wpf-tutorial.html [Accessed 25 June 2024].

using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace RecipeApp
{
    public partial class RecipeDetailsWindow : Window
    {
        private Recipe _recipe; // The recipe to be displayed (Microsoft Learn, 2024).
        private double _scaleFactor = 1.0; // The scale factor for ingredient quantities and calories (Microsoft Learn, 2024).

        //------------------------------------------------------------------------------------------------------------------------//

        // Constructor for RecipeDetailsWindow (Troelsen & Japikse, 2021).
        public RecipeDetailsWindow(Recipe recipe)
        {
            InitializeComponent();
            // Display window in centre of screen (Troelsen & Japikse, 2021).
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _recipe = recipe; 
            DisplayRecipe(); 
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Method to display recipe details (Troelsen & Japikse, 2021).
        private void DisplayRecipe()
        {
            // Sets the text block to the recipe name (Microsoft Learn, 2024).
            RecipeNameTextBlock.Text = _recipe.Name;
            // Sets the items source of the ingredients list box to the ingredients, scaled by the scale factor (Microsoft Learn, 2024).
            IngredientsListBox.ItemsSource = _recipe.Ingredients.Select(i => $"{i.Quantity * _scaleFactor} {i.Unit} {i.Name}, {i.Calories * _scaleFactor} cal, {i.FoodGroup}");
            // Sets the items source of the steps list box to the steps of the recipe (Microsoft Learn, 2024).
            StepsListBox.ItemsSource = _recipe.Steps;
            // Displays the total calories of the recipe (Microsoft Learn, 2024).
            DisplayTotalCalories();
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Method to display the total calories of the recipe (Microsoft Learn, 2024).
        private void DisplayTotalCalories()
        {
            
            double totalCalories = _recipe.Ingredients.Sum(i => i.Calories * _scaleFactor);
            TotalCaloriesTextBlock.Text = $"Total Calories: {totalCalories}";
            WarningTextBlock.Text = totalCalories > 300 ? "Warning: Total calories exceed 300!" : string.Empty;
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Event triggered by the scale buttons (Microsoft Learn, 2024).
        private void ScaleButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the content of the clicked button and set the scale factor (Microsoft Learn, 2024).
            string buttonContent = ((Button)sender).Content.ToString();
            _scaleFactor = buttonContent == "0.5x" ? 0.5 : buttonContent == "2x" ? 2.0 : 3.0;
            DisplayRecipe();
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Event triggered by the reset button (Walker, 2024).
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            // Reset the scale factor to 1.0 (Walker, 2024).
            _scaleFactor = 1.0;
            DisplayRecipe();
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Event triggered by the back button (Walker, 2024).
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Create a new instance of ViewRecipesWindow (Walker, 2024).
            ViewRecipesWindow viewRecipesWindow = new ViewRecipesWindow();
            
            viewRecipesWindow.Show();
            this.Close();
        }
    }
}

//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//
