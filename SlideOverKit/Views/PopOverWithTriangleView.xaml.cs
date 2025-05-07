using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace SlideOverKit.Views;

public partial class PopOverWithTriangleView : SlidePopupView
{
    public PopOverWithTriangleView()
    {
        InitializeComponent();

        this.LeftMargin = 10;
        this.BackgroundViewColor = Color.FromRgba(0, 0, 0, 125);

#if ANDROID
        this.TopMargin = 0;
#endif

        DoneButton.Clicked += (s, e) =>
        {
            this.HideMySelf();
        };
    }
}
