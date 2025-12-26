using AvaDemo.ViewModels;
using AvaDemo.Views.Controls.Text;
using CommunityToolkit.Mvvm.Input;

namespace AvaDemo.Views.Controls.Sidebar;

public partial class TextImageSidebarModel(MainViewModel view) : ViewModelBase
{
    [RelayCommand]
    public void OpenTextBlock()
    {
        view.Page = new TextBlockPage { DataContext = new TextBlockPageModel() };
    }

    [RelayCommand]
    public void OpenSelectTextBlock()
    {
        view.Page = new SelectTextBlockPage { DataContext = new SelectTextBoxPageModel() };
    }

    [RelayCommand]
    public void OpenImage()
    {
        view.Page = new ImagePage { DataContext = new ImagePageModel() };
    }

    [RelayCommand]
    public void OpenPathIcon()
    {
        view.Page = new PathIconPage { DataContext = new PathIconPageModel() };
    }
}
