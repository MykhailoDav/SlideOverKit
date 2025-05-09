using System;
using SlideOverKit;
using Android.Views;
using Android.Content;
using Microsoft.Maui.Controls.Platform;
using SlideOverKit.Platforms.Android.SlideOverKit;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace SlideOverKit.Platforms.Android.SlideOverKit;

public class MenuContainerPageDroidRenderer  : PageRenderer, ISlideOverKitPageRendererDroid
{
    public Action<ElementChangedEventArgs<Page>> OnElementChangedEvent { get; set; }

    public Action<bool, int,int,int,int> OnLayoutEvent { get; set; }

    public Action<int,int,int,int> OnSizeChangedEvent { get; set; }

    public MenuContainerPageDroidRenderer (Context context):base(context)
    {
        new SlideOverKitDroidHandler().Init (this, context);
    }

    protected override void OnElementChanged (ElementChangedEventArgs<Page> e)
    {
        base.OnElementChanged (e);
        OnElementChangedEvent?.Invoke(e);
    }

    //protected override void OnLayout (bool changed, int l, int t, int r, int b)
    //{
    //    base.OnLayout (changed, l, t, r, b);
    //    OnLayoutEvent?.Invoke(changed, l, t, r, b);
    //}

    protected override void OnSizeChanged (int w, int h, int oldw, int oldh)
    {
        base.OnSizeChanged (w, h, oldw, oldh);
        OnSizeChangedEvent?.Invoke(w, h, oldw, oldh);
    }
}

