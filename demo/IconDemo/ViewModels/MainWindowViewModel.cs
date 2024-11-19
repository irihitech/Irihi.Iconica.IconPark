using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using IconDemo.Views;
using Ursa.Controls;

namespace IconDemo.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        IconDetailViewModel = new IconDetailViewModel();
        SettingPanelViewModel = new SettingPanelViewModel();
        IconViewerViewModel = new IconViewerViewModel();
        SaveDialogCommand = new AsyncRelayCommand(OnSaveDialogAsync);
    }

    public IconDetailViewModel IconDetailViewModel { get; set; }
    public SettingPanelViewModel SettingPanelViewModel { get; set; }
    public IconViewerViewModel IconViewerViewModel { get; set; }

    public ICommand SaveDialogCommand { get; set; }

    private async Task OnSaveDialogAsync()
    {
        var vm = new ExportViewModel(SettingPanelViewModel, IconDetailViewModel.IconInfo);
        await OverlayDialog.ShowModal<ExportView, ExportViewModel>(vm,
            options: new OverlayDialogOptions
            {
                Title = "获取样式",
                Buttons = DialogButton.None
            });
    }
}