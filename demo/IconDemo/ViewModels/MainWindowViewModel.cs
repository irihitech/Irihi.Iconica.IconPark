using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IconDemo.Models;
using Irihi.Iconica;
using Irihi.Iconica.Icons;
using Ursa.Controls;

namespace IconDemo.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public IconDetailViewModel IconDetailViewModel { get; set; }
    public SettingPanelViewModel SettingPanelViewModel { get; set; }
    public IconViewerViewModel IconViewerViewModel { get; set; }
    
    public MainWindowViewModel()
    {
        IconDetailViewModel = new IconDetailViewModel();
        SettingPanelViewModel = new SettingPanelViewModel();
        IconViewerViewModel = new IconViewerViewModel();
        SaveDialogCommand = new AsyncRelayCommand(OnSaveDialogAsync);
    }

    private async Task OnSaveDialogAsync()
    {
        await MessageBox.ShowOverlayAsync("Hello World");
    }

    public ICommand SaveDialogCommand { get; set; }
}