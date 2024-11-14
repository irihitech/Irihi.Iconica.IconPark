using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IconDemo.Models;
using Irihi.Iconica;
using Irihi.Iconica.Icons;

namespace IconDemo.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private ObservableCollection<IconInfo> _iconNames;
    [ObservableProperty] private ObservableCollection<IconMode> _modes = new( Enum.GetValues<IconMode>());
    [ObservableProperty] private IconMode _selectedMode;
    [ObservableProperty] private Color? _outerFillColor = Color.Parse("#2F88FF");
    [ObservableProperty] private Color? _innerFillColor = Color.Parse("#43CCF8");
    [ObservableProperty] private Color? _outerStrokeColor = Color.Parse("#333");
    [ObservableProperty] private Color? _innerStrokeColor = Color.Parse("#FFF");
    [ObservableProperty] private SolidColorBrush _outerFillBrush;
    [ObservableProperty] private SolidColorBrush _innerFillBrush;
    [ObservableProperty] private SolidColorBrush _outerStrokeBrush;
    [ObservableProperty] private SolidColorBrush _innerStrokeBrush;

    public ICommand LoadCommand { get; set; }
    public ICommand ResetCommand { get; set; }
    
    public MainWindowViewModel()
    {
        IconNames = new ObservableCollection<IconInfo>();
        LoadCommand = new RelayCommand(OnLoad);
        ResetCommand = new RelayCommand(Reset);
        OuterFillBrush = new SolidColorBrush(OuterFillColor ?? Colors.Transparent);
        InnerFillBrush = new SolidColorBrush(InnerFillColor ?? Colors.Transparent);
        OuterStrokeBrush = new SolidColorBrush(OuterStrokeColor ?? Colors.Transparent);
        InnerStrokeBrush = new SolidColorBrush(InnerStrokeColor ?? Colors.Transparent);
    }

    private void Reset()
    {
        OuterFillColor = Color.Parse("#2F88FF");
        InnerFillColor = Color.Parse("#43CCF8");
        OuterStrokeColor = Color.Parse("#333");
        InnerStrokeColor = Color.Parse("#FFF");
        
    }

    partial void OnOuterFillColorChanged(Color? value)
    {
        OuterFillBrush = new SolidColorBrush(value ?? Colors.Transparent);
    }
    
    partial void OnInnerFillColorChanged(Color? value)
    {
        InnerFillBrush = new SolidColorBrush(value ?? Colors.Transparent);
    }
    
    partial void OnOuterStrokeColorChanged(Color? value)
    {
        OuterStrokeBrush = new SolidColorBrush(value ?? Colors.Transparent);
    }
    
    partial void OnInnerStrokeColorChanged(Color? value)
    {
        InnerStrokeBrush = new SolidColorBrush(value ?? Colors.Transparent);
    }

    private void OnLoad()
    {
        // Use reflection to get all icon names from IconPark.Icon assembly.
        // This is a workaround to avoid hardcoding icon names.

        IconNames.Clear();
        IconNames = new ObservableCollection<IconInfo>(IconInfo.IconInfos);

    }
}