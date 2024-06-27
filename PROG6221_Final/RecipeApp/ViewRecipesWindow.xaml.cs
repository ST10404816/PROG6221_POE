// Lisha Naidoo
// st10404816
// Group 1

// References:
// Lawrence, M., and Verzani, J. 2018. Programming Graphical User Interfaces in R. Boca Raton: CRC Press.
// Microsoft Learn. 2024. XAML overview (WPF .NET), 2 June 2023. [Online]. Available at: https://learn.microsoft.com/en-us/dotnet/desktop/wpf/xaml/?view=netdesktop-8.0 [Accessed 24 June 2024].
// Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. Berkeley: Apress.


using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace RecipeApp
{
    public partial class ViewRecipesWindow : Window
    {
        public ViewRecipesWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            LoadRecipes();
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // LoadRecipes method (Troelsen & Japikse, 2021).
        private void LoadRecipes()
        {
            RecipesListBox.ItemsSource = RecipeRepository.Recipes.OrderBy(r => r.Name).ToList();
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Event triggered when a recipe is selected from the ListBox (Troelsen & Japikse, 2021).
        private void RecipesListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Checks if there is a selected recipe and displays it(Troelsen & Japikse, 2021).
            if (RecipesListBox.SelectedItem != null)
            {
                
                Recipe selectedRecipe = (Recipe)RecipesListBox.SelectedItem;               
                RecipeDetailsWindow recipeDetailsWindow = new RecipeDetailsWindow(selectedRecipe);
                recipeDetailsWindow.Show();
                this.Close();
            }
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Event triggered by the Refresh button (Troelsen & Japikse, 2021).
        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            LoadRecipes();
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Event triggered by the Back button (Troelsen & Japikse, 2021).
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Event handler for filtering recipes by ingredient (Troelsen & Japikse, 2021).
        private void FilterByIngredientButton_Click(object sender, RoutedEventArgs e)
        {

            string ingredient = IngredientFilterTextBox.Text.ToLower();
            var filteredRecipes = RecipeRepository.Recipes
                .Where(r => r.Ingredients.Any(i => i.Name.ToLower().Contains(ingredient)))
                .OrderBy(r => r.Name)
                .ToList();
            RecipesListBox.ItemsSource = filteredRecipes;
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Event handler for filtering recipes by food group (Troelsen & Japikse, 2021).
        private void FilterByFoodGroupButton_Click(object sender, RoutedEventArgs e)
        {
            // Checks if an item is selected in the FoodGroupFilterComboBox (Troelsen & Japikse, 2021).
            if (FoodGroupFilterComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                // Filters recipes that belong to the selected food group and sort them by name (Microsoft Learn, 2024).

                string foodGroup = selectedItem.Content.ToString().ToLower();

                var filteredRecipes = RecipeRepository.Recipes
                    .Where(r => r.Ingredients.Any(i => i.FoodGroup.ToLower().Contains(foodGroup)))
                    .OrderBy(r => r.Name)
                    .ToList();
                
                RecipesListBox.ItemsSource = filteredRecipes;
            }
            else
            {
                // Shows an error message if no food group is selected (Microsoft Learn, 2024).
                MessageBox.Show("Please select a food group.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Event for filtering recipes by maximum calories (Lawrence & Verzani, 2018).
        private void FilterByMaxCaloriesButton_Click(object sender, RoutedEventArgs e)
        {
           
            if (int.TryParse(MaxCaloriesFilterTextBox.Text, out int maxCalories))
            {
                // Filter recipes where the sum of calories of all ingredients is less than or equal to the specified maximum (Lawrence & Verzani, 2018).
                var filteredRecipes = RecipeRepository.Recipes
                    .Where(r => r.Ingredients.Sum(i => i.Calories) <= maxCalories)
                    .OrderBy(r => r.Name)
                    .ToList();
                
                RecipesListBox.ItemsSource = filteredRecipes;
            }
            else
            {
                // Shows an error message if the input is not a valid number (Lawrence & Verzani, 2018).
                MessageBox.Show("Please enter a valid number for maximum calories.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//
