using Irihi.Iconica.Demo.Models;

namespace Irihi.Iconica.Demo.ViewModels;

public class IconParkPageViewModel
{
    public IconViewerViewModel Viewer { get; }
    public IconDetailViewModel Detail { get; }
    public IExportSettings SettingPanel { get; }

    public IconParkPageViewModel()
    {
        Viewer = new IconViewerViewModel(IconInfo.IconInfos, "IRIHI ICONICA 系列图标 - IconPark");
        Detail = new IconDetailViewModel(IconInfo.IconInfos);
        SettingPanel = new IconParkSettingPanelViewModel();
    }
}
