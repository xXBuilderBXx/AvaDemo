using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaDemo.Views.Controls.Inputs;

public partial class ListBoxPageModel : ViewModelBase
{
    [ObservableProperty]
    private string[] items = new string[] { "Item 1", "Item 2", "Item 3" };

    [ObservableProperty]
    private string selectedItem;
}
