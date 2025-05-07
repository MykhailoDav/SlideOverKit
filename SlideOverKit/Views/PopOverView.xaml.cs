using Microsoft.Maui.Controls;

namespace SlideOverKit.Views;

public partial class PopOverView : SlidePopupView
{
    public PopOverView()
    {
        InitializeComponent();
    }

    private void DoneButton_Clicked(object sender, EventArgs e)
    {
        HideMySelf();
    }
}
