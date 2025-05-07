using System;
using SlideOverKit;
using Android.Views;
using Android.Content;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform;
using SlideOverKit.Platforms.Android.SlideOverKit;

namespace SlideOverKit.Platforms.Android.SlideOverKit;

public class SlideMenuDroidRenderer : ViewRenderer <SlideMenuView, global::Android.Views.View>
{
    IDragGesture _dragGesture;

    internal IDragGesture GragGesture { get { return _dragGesture; } }

    public SlideMenuDroidRenderer (Context context):base(context)
    {
    }

    protected override void OnElementChanged (ElementChangedEventArgs<SlideMenuView> e)
    {
        base.OnElementChanged (e);
        InitDragGesture ();
    }

    void InitDragGesture ()
    {
        var menu = Element as SlideMenuView;
        if (menu == null)
        {
            return;
        }

        if (ScreenSizeHelper.ScreenHeight == 0 && ScreenSizeHelper.ScreenWidth == 0) {               
            ScreenSizeHelper.ScreenWidth = Resources.DisplayMetrics.WidthPixels / Resources.DisplayMetrics.Density;
            ScreenSizeHelper.ScreenHeight = Resources.DisplayMetrics.HeightPixels / Resources.DisplayMetrics.Density;
        }            
        _dragGesture = DragGestureFactory.GetGestureByView (menu, Resources.DisplayMetrics.Density);
        _dragGesture.RequestLayout = (l, t, r, b, desity) => {
            SetX ((float)l);
            SetY ((float)t);
        };           
    }
     
    public override bool OnTouchEvent (MotionEvent e)
    {
        if (_dragGesture == null)
        {
            return false;
        }

        MotionEventActions action = e.Action & MotionEventActions.Mask;
        if (action == MotionEventActions.Down)
        {
            _dragGesture.DragBegin (e.RawX, e.RawY);
        }

        if (action == MotionEventActions.Move)
        {
            _dragGesture.DragMoving (e.RawX, e.RawY);
        }

        if (action == MotionEventActions.Up)
        {
            _dragGesture.DragFinished ();
        }

        return true;
    }

}

