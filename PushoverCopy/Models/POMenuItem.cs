using System;

using Xamarin.Forms;

namespace PushoverCopy.Models
{
    public class POMenuItem : ContentPage
    {
        public POMenuItem()
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

