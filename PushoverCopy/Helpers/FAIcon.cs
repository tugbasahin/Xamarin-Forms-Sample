using System;

using Xamarin.Forms;

namespace PushoverCopy.Helpers
{
    public class FAIcon : ContentPage
    {
        public FAIcon()
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

