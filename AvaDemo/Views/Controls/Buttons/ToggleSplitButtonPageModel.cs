using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaDemo.Views.Controls.Buttons;

public partial class ToggleSplitButtonPageModel : ViewModelBase
{
    [ObservableProperty]
    private bool toggled;
}
