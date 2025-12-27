using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaDemo.Views.Controls.Inputs;

public partial class AutoCompleteBoxPageModel : ViewModelBase
{
    [ObservableProperty]
    private string[] items = new string[]
                {"cat", "camel", "cow", "chameleon", "mouse", "lion", "zebra" };
}
