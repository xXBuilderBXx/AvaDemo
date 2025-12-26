using AvaDemo.ViewModels;
using AvaDemo.Views.Controls.Layout;
using CommunityToolkit.Mvvm.Input;

namespace AvaDemo.Views.Controls.Sidebar;

public partial class LayoutSidebarModel(MainViewModel view) : ViewModelBase
{
    [RelayCommand]
    public void OpenBorder()
    {
        view.Page = new BorderPage { DataContext = new BorderPageModel() };
    }

    [RelayCommand]
    public void OpenCanvas()
    {
        view.Page = new CanvasPage { DataContext = new CanvasPageModel() };
    }

    [RelayCommand]
    public void OpenDockerPanel()
    {
        view.Page = new DockPanelPage { DataContext = new DockPanelPageModel() };
    }

    [RelayCommand]
    public void OpenGrid()
    {
        view.Page = new GridPage { DataContext = new GridPageModel() };
    }

    [RelayCommand]
    public void OpenPanel()
    {
        view.Page = new PanelPage { DataContext = new PanelPageModel() };
    }

    [RelayCommand]
    public void OpenRelativePanel()
    {
        view.Page = new RelativePanelPage { DataContext = new RelativePanelPageModel() };
    }

    [RelayCommand]
    public void OpenStackPanel()
    {
        view.Page = new StackPanelPage { DataContext = new StackPanelPage() };
    }

    [RelayCommand]
    public void OpenUniformGrid()
    {
        view.Page = new UniformGridPage { DataContext = new UniformGridPage() };
    }

    [RelayCommand]
    public void OpenWrapPanel()
    {
        view.Page = new WrapPanelPage { DataContext = new WrapPanelPageModel() };
    }

    [RelayCommand]
    public void OpenFlexBox()
    {
        view.Page = new FlexBoxPage { DataContext = new FlexBoxPageModel() };
    }

    [RelayCommand]
    public void OpenExpander()
    {
        view.Page = new ExpanderPage { DataContext = new ExpanderPageModel() };
    }

    [RelayCommand]
    public void OpenGridSplitter()
    {
        view.Page = new GridSplitterPage { DataContext = new GridSplitterPageModel() };
    }

    [RelayCommand]
    public void OpenScrollViewer()
    {
        view.Page = new ScrollViewerPage { DataContext = new ScrollViewerPageModel() };
    }

    [RelayCommand]
    public void OpenSplitView()
    {
        view.Page = new SplitViewPage { DataContext = new SplitViewPageModel() };
    }

    [RelayCommand]
    public void OpenTabControl()
    {
        view.Page = new TabControlPage { DataContext = new TabControlPageModel() };
    }

    [RelayCommand]
    public void OpenFlipView()
    {
        view.Page = new FlipViewPage { DataContext = new FlipViewPageModel() };
    }

    [RelayCommand]
    public void OpenInfoBadge()
    {
        view.Page = new InfoBadgePage { DataContext = new InfoBadgePageModel() };
    }
}
