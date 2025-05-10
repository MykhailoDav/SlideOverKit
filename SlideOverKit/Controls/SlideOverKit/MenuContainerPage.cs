namespace SlideOverKit;

public class MenuContainerPage : ContentPage, IMenuContainerPage, IPopupContainerPage
{
    public MenuContainerPage ()
    {
        PopupViews = [];
    }

    SlideMenuView slideMenu;
    public SlideMenuView SlideMenu {
        get {
            return slideMenu;
        }
        set {
            if (slideMenu != null)
            {
                slideMenu.Parent = null;
            }

            slideMenu = value;
            if (slideMenu != null)
            {
                slideMenu.Parent = this;
            }
        }
    }

    public Action ShowMenuAction { get; set; }

    public Action HideMenuAction { get; set; }

    public Dictionary<string, SlidePopupView> PopupViews { get; set; }

    public Action<string>  ShowPopupAction { get; set; }

    public Action HidePopupAction { get; set; }

    public void ShowMenu ()
    {
        ShowMenuAction?.Invoke();
    }

    public void HideMenu ()
    {
        HideMenuAction?.Invoke();
    }

    public void ShowPopup (string name)
    {
        ShowPopupAction?.Invoke(name);
    }

    public void HidePopup ()
    {
        HidePopupAction?.Invoke();
    }
}
