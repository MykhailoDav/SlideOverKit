using System;
using Microsoft.Maui.Controls;

namespace SlideOverKit.Views;

public class RightSideDetailPage : MenuContainerPage
{
    public RightSideDetailPage()
    {
        BackgroundColor = Colors.Wheat;
        BindingContext = this;
        Content = new VerticalStackLayout
        {
            BackgroundColor = Colors.Red,
            VerticalOptions = LayoutOptions.Center,
            Spacing = 10,
            Children = {
                new Button{
                    Text ="Show Menu",
                    Command = new Command(()=>{
                        this.ShowMenu();
                    })
                },
                new Button{
                    Text ="Hide Menu",
                    Command = new Command(()=>{
                        this.HideMenu();
                    })
                },
            }
        };

        this.SlideMenu = new RightSideMasterPage();
    }
}
