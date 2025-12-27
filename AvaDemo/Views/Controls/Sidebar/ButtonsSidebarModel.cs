using AvaDemo.ViewModels;
using AvaDemo.Views.Controls.Buttons;
using CommunityToolkit.Mvvm.Input;

namespace AvaDemo.Views.Controls.Sidebar;

public partial class ButtonsSidebarModel(MainViewModel view) : ViewModelBase
{
    [RelayCommand]
    public void OpenButton()
    {
        view.Page = new ButtonPage { DataContext = new ButtonPageModel() };
    }

    [RelayCommand]
    public void OpenRepeatButton()
    {
        view.Page = new RepeatButtonPage { DataContext = new RepeatButtonPageModel() };
    }

    [RelayCommand]
    public void OpenRadioButton()
    {
        view.Page = new RadioButtonPage { DataContext = new RadioButtonPageModel() };
    }

    [RelayCommand]
    public void OpenToggleButton()
    {
        view.Page = new ToggleButtonPage { DataContext = new ToggleButtonPageModel() };
    }

    [RelayCommand]
    public void OpenSpinnerButton()
    {
        view.Page = new SpinnerButtonPage { DataContext = new SpinnerButtonPageModel() };
    }

    [RelayCommand]
    public void OpenSplitButton()
    {
        view.Page = new SplitButtonPage { DataContext = new SplitButtonPageModel() };
    }

    [RelayCommand]
    public void OpenToggleSplitButton()
    {
        view.Page = new ToggleSplitButtonPage { DataContext = new ToggleSplitButtonPageModel() };
    }

    [RelayCommand]
    public void OpenMenu()
    {
        view.Page = new MenuPage { DataContext = new MenuPageModel() };
    }

    [RelayCommand]
    public void OpenFlyout()
    {
        view.Page = new FlyoutPage { DataContext = new FlyoutPageModel() };
    }

    [RelayCommand]
    public void OpenTooltip()
    {
        view.Page = new TooltipPage { DataContext = new TooltipPageModel() };
    }
}
