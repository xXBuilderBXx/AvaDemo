using AvaDemo.ViewModels;
using AvaDemo.Views.Controls.Inputs;
using CommunityToolkit.Mvvm.Input;

namespace AvaDemo.Views.Controls.Sidebar;

public partial class InputsSidebarModel(MainViewModel view) : ViewModelBase
{
    [RelayCommand]
    public void OpenTextBox()
    {
        view.Page = new TextBoxPage { DataContext = new TextBoxPageModel() };
    }

    [RelayCommand]
    public void OpenMaskedTextBox()
    {
        view.Page = new MaskedTextBoxPage { DataContext = new MaskedTextBoxPageModel() };
    }

    [RelayCommand]
    public void OpenListBox()
    {
        view.Page = new ListBoxPage { DataContext = new ListBoxPageModel() };
    }

    [RelayCommand]
    public void OpenComboBox()
    {
        view.Page = new ComboBoxPage { DataContext = new ComboBoxPageModel() };
    }

    [RelayCommand]
    public void OpenAutoCompleteBox()
    {
        view.Page = new AutoCompleteBoxPage { DataContext = new AutoCompleteBoxPageModel() };
    }

    [RelayCommand]
    public void OpenCheckBox()
    {
        view.Page = new CheckBoxPage { DataContext = new CheckBoxPageModel() };
    }

    [RelayCommand]
    public void OpenSlider()
    {
        view.Page = new SliderPage { DataContext = new SliderPageModel() };
    }

    [RelayCommand]
    public void OpenDatePicker()
    {
        view.Page = new DatePickerPage { DataContext = new DatePickerPageModel() };
    }

    [RelayCommand]
    public void OpenTimePicker()
    {
        view.Page = new TimePickerPage { DataContext = new TimePickerPageModel() };
    }

    [RelayCommand]
    public void OpenCalendar()
    {
        view.Page = new CalendarPage { DataContext = new CalendarPageModel() };
    }

    [RelayCommand]
    public void OpenCalendarDatePicker()
    {
        view.Page = new CalendarDatePickerPage { DataContext = new CalendarDatePickerPageModel() };
    }

    [RelayCommand]
    public void OpenColorPicker()
    {
        view.Page = new ColorPickerPage { DataContext = new ColorPickerPageModel() };
    }
}
