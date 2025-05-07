using System;
using SlideOverKit;
using Android.Content;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform;
using SlideOverKit.Platforms.Android.SlideOverKit;

namespace SlideOverKit.Platforms.Android.SlideOverKit;

public class SlidePopupViewRendererDroid(Context context) : VisualElementRenderer<SlidePopupView>(context)
{
    protected override void OnElementChanged(ElementChangedEventArgs<SlidePopupView> e)
    {
        base.OnElementChanged(e);
        if (ScreenSizeHelper.ScreenHeight == 0 && ScreenSizeHelper.ScreenWidth == 0)
        {
            ScreenSizeHelper.ScreenWidth = Resources.DisplayMetrics.WidthPixels / Resources.DisplayMetrics.Density;
            ScreenSizeHelper.ScreenHeight = Resources.DisplayMetrics.HeightPixels / Resources.DisplayMetrics.Density;
        }
    }
}

