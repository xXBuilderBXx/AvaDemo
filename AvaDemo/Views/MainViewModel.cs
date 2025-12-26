using AvaDemo.Views;
using AvaDemo.Views.Controls.Sidebar;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaDemo.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public MainViewModel()
    {
        sidebar = new LayoutSidebar() { DataContext = new LayoutSidebarModel(this) };
        PropertyChanged += MainViewModel_PropertyChanged;
    }

    private void MainViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "SelectedComboIndex")
        {
            switch (SelectedComboIndex)
            {
                case 0:
                    {
                        Page = new MainPage() { DataContext = new MainPageModel() };
                        Sidebar = new LayoutSidebar() { DataContext = new LayoutSidebarModel(this) };
                    }
                    break;
                case 1:
                    {
                        Page = new MainPage() { DataContext = new MainPageModel() };
                        Sidebar = new TextImageSidebar() { DataContext = new TextImageSidebarModel(this) };
                    }
                    break;
                case 2:
                    {
                        Page = new MainPage() { DataContext = new MainPageModel() };
                        Sidebar = new ButtonsSidebar() { DataContext = new ButtonsSidebarModel(this) };
                    }
                    break;
                case 3:
                    {
                        Page = new MainPage() { DataContext = new MainPageModel() };
                        Sidebar = new InputsSidebar() { DataContext = new InputsSidebarModel(this) };
                    }
                    break;
                case 4:
                    {
                        Page = new MainPage() { DataContext = new MainPageModel() };
                        Sidebar = new ItemsSidebar() { DataContext = new ItemsSidebarModel(this) };
                    }
                    break;
            }
        }
    }

    [ObservableProperty]
    private int selectedComboIndex;

    [ObservableProperty]
    private string comboTitleText = "Text & Images";

    [ObservableProperty]
    private string comboTitleData = "Data & Items";

    [ObservableProperty]
    private UserControl page = new MainPage() { DataContext = new MainPageModel() };

    [ObservableProperty]
    private UserControl sidebar;
}
