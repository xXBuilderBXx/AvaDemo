using AvaDemo.ViewModels;
using AvaDemo.Views.Controls.Items;
using CommunityToolkit.Mvvm.Input;

namespace AvaDemo.Views.Controls.Sidebar;

public partial class ItemsSidebarModel(MainViewModel view) : ViewModelBase
{
    [RelayCommand]
    public void OpenDataGrid()
    {
        view.Page = new DataGridPage { DataContext = new DataGridPageModel() };
    }

    [RelayCommand]
    public void OpenItemsControl()
    {
        view.Page = new ItemsControlPage { DataContext = new ItemsControlPageModel() };
    }

    [RelayCommand]
    public void OpenItemsRepeater()
    {
        view.Page = new ItemsRepeaterPage { DataContext = new ItemsRepeaterPageModel() };
    }
}
