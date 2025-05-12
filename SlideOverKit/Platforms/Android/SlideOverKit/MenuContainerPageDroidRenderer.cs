using Android.Content;
using Android.Views;
using Microsoft.Maui.Controls;
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
        var viewGroup = base.CreatePlatformView();

        new SlideOverKitDroidHandler().Init(this, MauiContext.Context!);

        viewGroup.ViewTreeObserver.GlobalLayout += (sender, args) =>
        {
            var width = viewGroup.Width;
            var height = viewGroup.Height;

            OnLayoutEvent?.Invoke(true, 0, 0, width, height);
        };

        viewGroup.LayoutChange += (sender, e) =>
        {
            OnSizeChangedEvent?.Invoke(e.Right - e.Left, e.Bottom - e.Top, e.OldRight - e.OldLeft, e.OldBottom - e.OldTop);
        };

        return viewGroup;
    }

    public override void SetVirtualView(IView view)
    {
        base.SetVirtualView(view);

        if (view is Page page)
        {
            OnElementChangedEvent?.Invoke(new ElementChangedEventArgs<Page>(null, page));
        }
    }
}
