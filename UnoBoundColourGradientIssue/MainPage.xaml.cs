// <copyright file="MainPage.xaml.cs" company="Visual Software Systems Ltd.">Copyright (c) 2023 All rights reserved</copyright>

namespace UnoBoundColourGradientIssue
{
    using Microsoft.UI.Xaml.Controls;

    /// <summary>
    /// The code behind the main page.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();

            this.DataContext = new MainViewModel();
        }

        /// <summary>
        /// The current view model
        /// </summary>
        public MainViewModel VM
        {
            get
            {
                return this.DataContext as MainViewModel;
            }
        }

        private void Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            this.VM.FlipContext();
        }
    }
}