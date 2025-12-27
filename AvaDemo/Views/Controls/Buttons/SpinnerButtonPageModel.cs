using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaDemo.Views.Controls.Buttons;

public partial class SpinnerButtonPageModel : ViewModelBase
{
    [ObservableProperty]
    public int number = 1;
}
