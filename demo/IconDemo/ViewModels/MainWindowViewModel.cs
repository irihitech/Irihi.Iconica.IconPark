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

    [ObservableProperty] private Color? _innerFillColor = Color.Parse("#43CCF8");
    [ObservableProperty] private Color? _innerStrokeColor = Color.Parse("#FFF");
    [ObservableProperty] private ObservableCollection<IconMode> _modes = new()
        { IconMode.Line, IconMode.Fill, IconMode.TwoTone, IconMode.MultiColor };
    [ObservableProperty] private Color? _outerFillColor = Color.Parse("#2F88FF");
    [ObservableProperty] private Color? _outerStrokeColor = Color.Parse("#333");
    [ObservableProperty] private IconMode _selectedMode;
    
    public MainWindowViewModel()
    {
        ResetCommand = new RelayCommand(Reset);
        // OnLoad();
    }
    
    public ICommand ResetCommand { get; set; }
    


    private void Reset()
    {
        OuterFillColor = Color.Parse("#2F88FF");
        InnerFillColor = Color.Parse("#43CCF8");
        OuterStrokeColor = Color.Parse("#333");
        InnerStrokeColor = Color.Parse("#FFF");
    }

    
}