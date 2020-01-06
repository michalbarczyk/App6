using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace App6
{
    public partial class BasePage : ContentPage
    {
        public BasePage(ContentView innerView, string pageTitle, ContentView titleBarExtension = null)
        {
            // InitializeComponent();

            NavigationPage.SetTitleView(this, new Label { 
                Text = pageTitle,
                FontSize = 18,
                TextColor = Color.Azure,
                HorizontalTextAlignment = TextAlignment.Center});

            var topButton = new Button { Text = "TOP BUTTON" };
            var bottomButton = new Button { Text = "BOTTOM BUTTON" };

            StackLayout layout = null;

            if (titleBarExtension == null)
            {
                layout = new StackLayout
                {
                    Padding = new Thickness(0),
                    Children =
                    {
                        topButton,
                        innerView,
                        bottomButton
                    }
                };
            }
            else
            {
                layout = new StackLayout
                {
                    Padding = new Thickness(0),
                    Children =
                    {
                        titleBarExtension,
                        topButton,
                        innerView,
                        bottomButton
                    }
                };
            }

            Content = layout;

        }
    }
}