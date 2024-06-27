// Lisha Naidoo
// st10404816
// Group 1

// References:
// Alls, J. 2022. High-Performance Programming in C# and .NET - Google Books. Birmingham: Packt.
// Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. Berkeley: Apress.


using System.Windows;

namespace RecipeApp
{
    public partial class MainWindow : Window
    {
        // Constructor (Alls, 2022).
        public MainWindow()
        {
            // Initializes XAML components for this window (Troelsen & Japikse, 2021).
            InitializeComponent();

            // Sets window to the center of the screen (Alls, 2022).
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Event triggered by ViewRecipesButton button (Troelsen & Japikse, 2021).
        private void ViewRecipesButton_Click(object sender, RoutedEventArgs e)
        {
            // Creates an instance of the ViewRecipesWindow (Troelsen & Japikse, 2021).
            ViewRecipesWindow viewRecipesWindow = new ViewRecipesWindow();

            // Shows the ViewRecipesWindow (Troelsen & Japikse, 2021).
            viewRecipesWindow.Show();

            // Closes the MainWindow (Troelsen & Japikse, 2021).
            this.Close();
        }

        //------------------------------------------------------------------------------------------------------------------------//

        // Event triggered by AddRecipeButton button (Alls, 2022).
        private void AddRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            // Creates an instance of the AddRecipeWindow (Troelsen & Japikse, 2021).
            AddRecipeWindow addRecipeWindow = new AddRecipeWindow();

            // Shows the AddRecipeWindow (Troelsen & Japikse, 2021).
            addRecipeWindow.Show();

            // Closes the MainWindow (Troelsen & Japikse, 2021).
            this.Close();
        }
    }
}

//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//