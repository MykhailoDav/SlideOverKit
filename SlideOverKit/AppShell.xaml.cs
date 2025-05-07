
using SlideOverKit.Views;

namespace SlideOverKit;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(RightSideDetailPage), typeof(RightSideDetailPage));
        Routing.RegisterRoute(nameof(SlideUpMenuPage), typeof(SlideUpMenuPage));
        Routing.RegisterRoute(nameof(SlideDownMenuPage), typeof(SlideDownMenuPage));
        Routing.RegisterRoute(nameof(QuickInnerMenuPage), typeof(QuickInnerMenuPage));
        Routing.RegisterRoute(nameof(PopOverPage), typeof(PopOverPage));
    }
}
