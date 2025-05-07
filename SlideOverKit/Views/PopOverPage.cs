using Microsoft.Maui.Controls;
using SlideOverKit.Views;

namespace SlideOverKit.Views;

public class PopOverPage : MenuContainerPage
{
    public PopOverPage()
    {
        var button = new Button
        {
            Text = "Show First Popup",
            Command = new Command(() =>
            {
                ShowPopup("FirstPopup");
            })
        };

        this.PopupViews.Add("FirstPopup", new PopOverView());
        this.PopupViews.Add("SecondPopup", new PopOverWithTriangleView());

        this.Content = new ScrollView
        {
            Orientation = ScrollOrientation.Both,
            Content = new VerticalStackLayout
            {
                Spacing = 10,
                Children =
                {
                    new BoxView { BackgroundColor = Colors.Transparent, HeightRequest = 300, WidthRequest = 300 },
                    button,
                    new BoxView { BackgroundColor = Colors.Transparent, HeightRequest = 500, WidthRequest = 500 },
                }
            }
        };

        this.ToolbarItems.Add(new ToolbarItem
        {
            Command = new Command(() =>
            {
                if (this.PopupViews["SecondPopup"].IsShown)
                {
                    this.HidePopup();
                }
                else
                {
                    this.ShowPopup("SecondPopup");
                }
            }),
            IconImageSource = "Filter_Blue.png",
            Text = "Filter",
            Priority = 0
        });

        PopupViewAttached.SetTarget(button, "FirstPopup");
    }
}
