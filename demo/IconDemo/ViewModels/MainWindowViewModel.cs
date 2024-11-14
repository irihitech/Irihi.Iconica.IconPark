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

namespace IconDemo.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private List<IconInfo>? _activeIconNames;
    [ObservableProperty] private Rect _bounds;

    [ObservableProperty] private List<IconInfo>? _iconNames;
    [ObservableProperty] private Color? _innerFillColor = Color.Parse("#43CCF8");
    [ObservableProperty] private Color? _innerStrokeColor = Color.Parse("#FFF");

    [ObservableProperty] private ObservableCollection<IconMode> _modes = new()
        { IconMode.Line, IconMode.Fill, IconMode.TwoTone, IconMode.MultiColor };

    [ObservableProperty] private Color? _outerFillColor = Color.Parse("#2F88FF");
    [ObservableProperty] private Color? _outerStrokeColor = Color.Parse("#333");
    [ObservableProperty] private string? _searchInput;
    [ObservableProperty] private IconMode _selectedMode;
    [ObservableProperty] private List<List<IconInfo>> _virtualizedNames = new();

    public MainWindowViewModel()
    {
        LoadCommand = new RelayCommand(OnLoad);
        ResetCommand = new RelayCommand(Reset);
        OnLoad();
    }

    public ICommand LoadCommand { get; set; }
    public ICommand ResetCommand { get; set; }
    
    private void OnLoad()
    {
        IconNames = IconInfo.IconInfos;
        ActiveIconNames = IconNames;
    }

    private void Reset()
    {
        OuterFillColor = Color.Parse("#2F88FF");
        InnerFillColor = Color.Parse("#43CCF8");
        OuterStrokeColor = Color.Parse("#333");
        InnerStrokeColor = Color.Parse("#FFF");
    }

    partial void OnSearchInputChanged(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            ActiveIconNames = IconNames;
            return;
        }

        ActiveIconNames = IconNames
                          ?.Where(n => n.Keywords.Any(b => b.Contains(value, StringComparison.OrdinalIgnoreCase)))
                          .ToList();
    }

    partial void OnActiveIconNamesChanged(List<IconInfo>? value)
    {
        if (value is null) return;
        VirtualizedNames = value.Chunk(8).Select(a => a.ToList()).ToList();
    }
}