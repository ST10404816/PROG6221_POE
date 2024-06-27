﻿#pragma checksum "..\..\ViewRecipesWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5CF1584B50E7100A54B3866D1B77C86A63FF9608D1DAF53C46BFE9D6E7E5F9C0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace RecipeApp {
    
    
    /// <summary>
    /// ViewRecipesWindow
    /// </summary>
    public partial class ViewRecipesWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\ViewRecipesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IngredientFilterTextBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ViewRecipesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FilterByIngredientButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ViewRecipesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FoodGroupFilterComboBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\ViewRecipesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FilterByFoodGroupButton;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\ViewRecipesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaxCaloriesFilterTextBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\ViewRecipesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FilterByMaxCaloriesButton;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\ViewRecipesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RecipesListBox;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\ViewRecipesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RefreshButton;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\ViewRecipesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/viewrecipeswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ViewRecipesWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.IngredientFilterTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.FilterByIngredientButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\ViewRecipesWindow.xaml"
            this.FilterByIngredientButton.Click += new System.Windows.RoutedEventHandler(this.FilterByIngredientButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FoodGroupFilterComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.FilterByFoodGroupButton = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\ViewRecipesWindow.xaml"
            this.FilterByFoodGroupButton.Click += new System.Windows.RoutedEventHandler(this.FilterByFoodGroupButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MaxCaloriesFilterTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.FilterByMaxCaloriesButton = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\ViewRecipesWindow.xaml"
            this.FilterByMaxCaloriesButton.Click += new System.Windows.RoutedEventHandler(this.FilterByMaxCaloriesButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RecipesListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 62 "..\..\ViewRecipesWindow.xaml"
            this.RecipesListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RecipesListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RefreshButton = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\ViewRecipesWindow.xaml"
            this.RefreshButton.Click += new System.Windows.RoutedEventHandler(this.RefreshButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\ViewRecipesWindow.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
