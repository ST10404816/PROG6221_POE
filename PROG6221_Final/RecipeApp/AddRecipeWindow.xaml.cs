// Lisha Naidoo
// st10404816
// Group 1

// References:
// Alls, J. 2022. High-Performance Programming in C# and .NET - Google Books. Birmingham: Packt.
// Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. Berkeley: Apress.
// Lawrence, M., and Verzani, J. 2018. Programming Graphical User Interfaces in R. Boca Raton: CRC Press.


using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace RecipeApp
{
    public partial class AddRecipeWindow : Window
    {
        // List to store the ingredients added to the recipe (Troelsen & Japikse, 2021).
        private List<Ingredient> _ingredients = new List<Ingredient>();

        //------------------------------------------------------------------------------------------------------------------------//

        public AddRecipeWindow()
        {
            InitializeComponent();
            // Center the window on the screen (Alls, 2022).
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            // Initialize ComboBox items (Alls, 2022).
            InitializeFoodGroupComboBox();
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Method to initialize ComboBox of food groups and tooltips (Alls, 2022).
        private void InitializeFoodGroupComboBox()
        {
            AddComboBoxItemWithToolTip("Starchy Foods", "Includes bread, rice, pasta, etc.");
            AddComboBoxItemWithToolTip("Fruits and Vegetables", "Includes all kinds of fruits and vegetables.");
            AddComboBoxItemWithToolTip("Legumes", "Includes beans, lentils, peas, etc.");
            AddComboBoxItemWithToolTip("Protein", "Includes meat, fish, eggs, tofu, etc.");
            AddComboBoxItemWithToolTip("Dairy", "Includes milk, cheese, yogurt, etc.");
            AddComboBoxItemWithToolTip("Fats and Oils", "Includes butter, oils, nuts, etc.");
            AddComboBoxItemWithToolTip("Water", "Essential for hydration.");

            // Set the default selected item (Lawrence & Verzani, 2018).
            IngredientFoodGroupComboBox.SelectedIndex = 0;
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Method to add ComboBox items with tooltips (Alls, 2022).
        private void AddComboBoxItemWithToolTip(string content, string toolTip)
        {
   
            ComboBoxItem item = new ComboBoxItem
            {
                Content = content,
                ToolTip = new ToolTip { Content = toolTip }
            };
            IngredientFoodGroupComboBox.Items.Add(item);
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Event triggered by "Add Ingredient" button  (Troelsen & Japikse, 2021).
        private void AddIngredientButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Retrieve and parse input values (Troelsen & Japikse, 2021).
                string name = IngredientNameTextBox.Text;
                double quantity = double.Parse(IngredientQuantityTextBox.Text);
                string unit = IngredientUnitTextBox.Text;
                int calories = int.Parse(IngredientCaloriesTextBox.Text);
                string foodGroup = ((ComboBoxItem)IngredientFoodGroupComboBox.SelectedItem).Content.ToString();

                // Creates a new Ingredient object (Troelsen & Japikse, 2021).
                Ingredient newIngredient = new Ingredient
                {
                    Name = name,
                    Quantity = quantity,
                    Unit = unit,
                    Calories = calories,
                    FoodGroup = foodGroup
                };

                // Adds the new ingredient to the list (Troelsen & Japikse, 2021).
                _ingredients.Add(newIngredient);
                IngredientsListBox.Items.Add($"{quantity} {unit} {name}, {calories} cal, {foodGroup}");
                
                ClearIngredientFields();
                MessageBox.Show("Ingredient added successfully!");
            }
            catch (FormatException)
            {
                // Invalid input (Lawrence & Verzani, 2018).
                MessageBox.Show("Invalid input format. Please check your input and try again.");
            }
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Event triggered "Save Recipe" button (Troelsen & Japikse, 2021).
        private void SaveRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            // If statement checks if there are any ingredients added (Troelsen & Japikse, 2021).
            if (_ingredients.Count == 0)
            {
                MessageBox.Show("Please add at least one ingredient to save the recipe.");
                return;
            }

            // Retrieves the recipe name and steps (Troelsen & Japikse, 2021).
            string name = RecipeNameTextBox.Text;
            string[] steps = StepsTextBox.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Creates a new Recipe object (Troelsen & Japikse, 2021).
            Recipe newRecipe = new Recipe
            {
                Name = name,
                Ingredients = new List<Ingredient>(_ingredients),
                Steps = new List<string>(steps)
            };

            // Adds the new recipe (Troelsen & Japikse, 2021).
            RecipeRepository.Recipes.Add(newRecipe);

            MessageBox.Show("Recipe added successfully!");

            // Closes window (Troelsen & Japikse, 2021).
            ClearAllFields();
            RecipeDetailsWindow recipeDetailsWindow = new RecipeDetailsWindow(newRecipe);
            recipeDetailsWindow.Show();
            this.Close();
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Event triggered by "Back" button (Troelsen & Japikse, 2021).
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Event triggered "Clear" button (Troelsen & Japikse, 2021).
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearAllFields();

            MessageBox.Show("Fields cleared successfully!");
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Method to clear all input fields (Alls, 2022).
        private void ClearAllFields()
        {
            RecipeNameTextBox.Clear();
            ClearIngredientFields();
            IngredientsListBox.Items.Clear();
            StepsTextBox.Clear();
            _ingredients.Clear();
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Method to clear ingredient input fields (Alls, 2022).
        private void ClearIngredientFields()
        {
            IngredientNameTextBox.Clear();
            IngredientQuantityTextBox.Clear();
            IngredientUnitTextBox.Clear();
            IngredientCaloriesTextBox.Clear();
            IngredientFoodGroupComboBox.SelectedIndex = 0;
        }

        //------------------------------------------------------------------------------------------------------------------------//
    }

}
 //------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//
