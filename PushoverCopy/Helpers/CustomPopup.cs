using System;

using Xamarin.Forms;

namespace PushoverCopy.Helpers
{
    public class CustomPopup : ContentPage
    {
        public CustomPopup()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

