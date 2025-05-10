using Android.Content;
using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace SlideOverKit.Platforms.Android.SlideOverKit;

public class MenuContainerPageDroidRenderer : PageHandler, ISlideOverKitPageRendererDroid
{
    public Action<ElementChangedEventArgs<Page>> OnElementChangedEvent { get; set; }

    public Action<bool, int, int, int, int> OnLayoutEvent { get; set; }

    public Action<int, int, int, int> OnSizeChangedEvent { get; set; }

    protected override ContentViewGroup CreatePlatformView()
    {
        new SlideOverKitDroidHandler().Init(this, MauiContext.Context!);
        return base.CreatePlatformView();
    }
    /* 
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            OnElementChangedEvent?.Invoke(e);
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);
            OnLayoutEvent?.Invoke(changed, l, t, r, b);
        }

        protected override void OnArranged(int w, int h, int oldw, int oldh)
        {
            base.OnSizeChanged(w, h, oldw, oldh);
            OnSizeChangedEvent?.Invoke(w, h, oldw, oldh);
        } */
}

