using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaDemo.Views.Controls.Inputs;

public partial class ComboBoxPageModel : ViewModelBase
{
    [ObservableProperty]
    private int selectedIndex;
}
