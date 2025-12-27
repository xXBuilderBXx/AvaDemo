using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaDemo.Views.Controls.Buttons;

public partial class ToggleButtonPageModel : ViewModelBase
{
    [ObservableProperty]
    private bool toggled;
}
