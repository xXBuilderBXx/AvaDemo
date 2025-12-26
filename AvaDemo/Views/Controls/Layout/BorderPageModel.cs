using Avalonia;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaDemo.Views.Controls.Layout;

public partial class BorderPageModel : ViewModelBase
{
    public BorderPageModel()
    {
        PropertyChanged += BorderPageModel_PropertyChanged;
    }

    private void BorderPageModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "BorderThickness")
            BorderThicknessBrush = new Thickness(BorderThickness);
    }

    [ObservableProperty]
    private string background = "";

    [ObservableProperty]
    private string borderBrush = "#808080";

    [ObservableProperty]
    private Thickness borderThicknessBrush = new Thickness(1);

    [ObservableProperty]
    private int borderThickness = 1;
}
