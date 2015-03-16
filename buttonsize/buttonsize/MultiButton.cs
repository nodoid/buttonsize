using System;

using Xamarin.Forms;

namespace buttonsize
{
    public class MultiButton : ContentPage
    {
        public MultiButton()
        {
            var third = App.ScreenSize.Width / 3;
            var quarter = App.ScreenSize.Width / 4;
            var fifth = App.ScreenSize.Width / 5;

            var thirdButton = new Button()
            {
                Text = "1/3",
                TextColor = Color.Blue,
                WidthRequest = third
            };
            var quarterdButton = new Button()
            {
                Text = "1/4",
                TextColor = Color.Red,
                WidthRequest = quarter
            };
            var fifthButton = new Button()
            {
                Text = "1/5",
                TextColor = Color.Green,
                WidthRequest = fifth
            };
            
            Content = new StackLayout
            { 
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.StartAndExpand,
                Children =
                {
                    thirdButton, quarterdButton, fifthButton
                }
            };
        }
    }
}


