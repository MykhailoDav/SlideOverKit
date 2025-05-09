using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using SlideOverKit.Platforms.Android.SlideOverKit;
using SlideOverKit.ViewModels;
using SlideOverKit.Views;

namespace SlideOverKit;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
#if ANDROID
            .UseMauiCompatibility()
#endif
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
        .ConfigureMauiHandlers((handlers) =>
         {
#if ANDROID
             handlers.AddCompatibilityRenderer<MenuContainerPage, MenuContainerPageDroidRenderer>();
             handlers.AddHandler<SlideMenuView, SlideMenuDroidRenderer>();
             handlers.AddHandler<SlidePopupView, SlidePopupViewRendererDroid>();

#endif
         });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<MainPageViewModel>();

        builder.Services.AddTransient<PopOverPage>();
        builder.Services.AddTransient<PopOverView>();
        builder.Services.AddTransient<PopOverWithTriangleView>();
        builder.Services.AddTransient<QuickInnerMenuPage>();
        builder.Services.AddTransient<QuickInnerMenuView>();


        return builder.Build();
    }
}
