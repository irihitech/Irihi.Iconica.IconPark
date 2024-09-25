using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IconPark.Icons;

namespace IconDemo.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private ObservableCollection<string> _iconNames;
    [ObservableProperty] private ObservableCollection<IconMode> _modes = new( Enum.GetValues<IconMode>());
    [ObservableProperty] private IconMode _selectedMode;

    public ICommand LoadCommand { get; set; }
    
    public MainWindowViewModel()
    {
        IconNames = new ObservableCollection<string>();
        LoadCommand = new RelayCommand(OnLoad);
    }

    private void OnLoad()
    {
        // Use reflection to get all icon names from IconPark.Icon assembly.
        // This is a workaround to avoid hardcoding icon names.
        
        var assembly = typeof(IconPark.Icons.IconParkIconBase).Assembly;
        var iconNames = assembly.GetTypes()
            .Where(t=>t.BaseType == typeof(IconPark.Icons.IconParkIconBase))
            .Select(t => t.Name)
            .ToList();
        IconNames = new ObservableCollection<string>(iconNames);
    }
}