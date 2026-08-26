using Irihi.Iconica.Demo.Models;

namespace Irihi.Iconica.Demo.ViewModels;

public class TDesignPageViewModel
{
    public IconViewerViewModel Viewer { get; }
    public IconDetailViewModel Detail { get; }
    public IExportSettings SettingPanel { get; }

    public TDesignPageViewModel()
    {
        Viewer = new IconViewerViewModel(IconInfo.TDesignIconInfos, "IRIHI ICONICA 系列图标 - TDesign")
        {
            Filter = IconInfo.IsOutline
        };
        Detail = new IconDetailViewModel(IconInfo.TDesignIconInfos);
        SettingPanel = new TDesignSettingPanelViewModel();
    }
}
