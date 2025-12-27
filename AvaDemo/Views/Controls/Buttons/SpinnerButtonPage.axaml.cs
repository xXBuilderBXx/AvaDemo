using AvaDemo.Views.Controls.Buttons;
using Avalonia.Controls;

namespace AvaDemo;

public partial class SpinnerButtonPage : UserControl
{
    public SpinnerButtonPage()
    {
        InitializeComponent();
    }

    private void ButtonSpinner_Spin(object? sender, SpinEventArgs e)
    {
        if (e.Direction == SpinDirection.Increase)
        {
            if ((DataContext as SpinnerButtonPageModel).Number == 100)
                return;
            (DataContext as SpinnerButtonPageModel).Number += 1;
        }
        else
        {
            if ((DataContext as SpinnerButtonPageModel).Number == 1)
                return;
            (DataContext as SpinnerButtonPageModel).Number -= 1;
        }
    }
}