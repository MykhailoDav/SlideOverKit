using Microsoft.Maui.Controls;
using SlideOverKit.Views;

namespace SlideOverKit.Views;

public class QuickInnerMenuPage : MenuContainerPage
{
    public QuickInnerMenuPage()
    {
        Content = new StackLayout
        {
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
            Children =
            {
                new Button { Text = "Quick menu from right", Command = ShowMenuFromRight },
                new Button { Text = "Quick menu from left", Command = ShowMenuFromLeft },
                new Button { Text = "Quick menu from top", Command = ShowMenuFromTop },
                new Button { Text = "Quick menu from bottom", Command = ShowMenuFromBottom },
                new Button { Text = "Go Back to Main page", Command = GoBackToMainPage }
            }
        };

        this.SlideMenu = new QuickInnerMenuView(MenuOrientation.RightToLeft);
    }

    public static Command ShowMenuFromRight => new(() =>
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new QuickInnerMenuPage
        {
            SlideMenu = new QuickInnerMenuView(MenuOrientation.RightToLeft)
        });
    });

    public static Command ShowMenuFromLeft => new(() =>
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new QuickInnerMenuPage
        {
            SlideMenu = new QuickInnerMenuView(MenuOrientation.LeftToRight)
        });
    });

    public static Command ShowMenuFromTop => new(() =>
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new QuickInnerMenuPage
        {
            SlideMenu = new QuickInnerMenuView(MenuOrientation.TopToBottom)
        });
    });

    public static Command ShowMenuFromBottom => new(() =>
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new QuickInnerMenuPage
        {
            SlideMenu = new QuickInnerMenuView(MenuOrientation.BottomToTop)
        });
    });

    public static Command GoBackToMainPage => new(() =>
    {
        Application.Current.MainPage.Navigation.PopModalAsync();
    });
}
