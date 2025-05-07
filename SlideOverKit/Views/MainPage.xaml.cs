using Microsoft.Maui.Controls;
using SlideOverKit.ViewModels;

namespace SlideOverKit.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
