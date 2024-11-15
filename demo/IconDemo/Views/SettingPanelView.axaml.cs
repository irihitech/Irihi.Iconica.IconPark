using Avalonia.Controls;
using IconDemo.ViewModels;

namespace IconDemo.Views;

public partial class SettingPanelView : UserControl
{
    public SettingPanelView()
    {
        InitializeComponent();
        DataContext = new SettingPanelViewModel();
    }
}