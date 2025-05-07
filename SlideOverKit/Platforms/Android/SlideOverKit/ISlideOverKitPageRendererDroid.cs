using Microsoft.Maui.Controls.Platform;

namespace SlideOverKit.Platforms.Android.SlideOverKit;

public interface ISlideOverKitPageRendererDroid
{
    Action<ElementChangedEventArgs<Page>> OnElementChangedEvent { get; set; }

    Action<bool, int,int,int,int> OnLayoutEvent { get; set; }

    Action<int,int,int,int> OnSizeChangedEvent { get; set; }
}

