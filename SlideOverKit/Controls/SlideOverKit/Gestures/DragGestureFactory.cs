using System;

namespace SlideOverKit;

public class DragGestureFactory
{
    public static IDragGesture GetGestureByView(SlideMenuView view, double density = 1.0f)
    {
        return view.MenuOrientations switch
        {
            MenuOrientation.TopToBottom => new VerticalGesture(view, density),
            MenuOrientation.BottomToTop => new VerticalGesture(view, density),
            MenuOrientation.LeftToRight => new HorizontalGestures(view, density),
            MenuOrientation.RightToLeft => new HorizontalGestures(view, density),
            _ => new VerticalGesture(view, density),
        };
    }
}

internal class GestureBase
{
    protected double _oldX, _oldY, _left, _right, _top, _bottom = 0;
    protected double _density = 1;
    protected bool _willShown = true;

    internal GestureBase(SlideMenuView view, double density)
    {
        _density = density;
        view.GetIsShown = () =>
        {
            return !_willShown;
        };
    }



    public Action<double, double, double, double, double> RequestLayout
    {
        get;
        set;
    }

    public Action<bool, double> NeedShowBackgroundView
    {
        get;
        set;
    }
}

