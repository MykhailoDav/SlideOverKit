using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SlideOverKit.Views;

namespace SlideOverKit.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    [RelayCommand]
    private static async Task LaunchRightSideMasterDetailPage()
    {
        await Shell.Current.GoToAsync(nameof(RightSideDetailPage));
    }

    [RelayCommand]
    private static async Task LaunchSlideUpMenuPage()
    {
        await Shell.Current.GoToAsync(nameof(SlideUpMenuPage));
    }

    [RelayCommand]
    private static async Task LaunchSlideDownMenuPage()
    {
        await Shell.Current.GoToAsync(nameof(SlideDownMenuPage));
    }

    [RelayCommand]
    private static async Task LaunchQuickInnerMenuPage()
    {
        await Shell.Current.GoToAsync(nameof(QuickInnerMenuPage));
    }

    [RelayCommand]
    private static async Task LaunchPopoversPage()
    {
        await Shell.Current.GoToAsync(nameof(PopOverPage));
    }
}
