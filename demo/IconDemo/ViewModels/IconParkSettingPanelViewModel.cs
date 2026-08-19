using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Avalonia.Media;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using IconDemo.Messages;
using Irihi.Iconica.IconPark;

namespace IconDemo.ViewModels;

public partial class IconParkSettingPanelViewModel : ObservableObject, IExportSettings
{
    private readonly Color? _darkDefaultInnerFillColor = Color.Parse("#FF33C2B0");
    private readonly Color? _darkDefaultInnerStrokeColor = Color.Parse("#FF333333");
    private readonly Color? _darkDefaultOuterFillColor = Color.Parse("#FF54A9FF");
    private readonly Color? _darkDefaultOuterStrokeColor = Color.Parse("#FFFFFFFF");
    private readonly Color? _darkDefaultFallbackColor = Colors.Black;

    private readonly Color? _lightDefaultInnerFillColor = Color.Parse("#FF00B3A1");
    private readonly Color? _lightDefaultInnerStrokeColor = Color.Parse("#FFFFFFFF");
    private readonly Color? _lightDefaultOuterFillColor = Color.Parse("#FF0077FA");
    private readonly Color? _lightDefaultOuterStrokeColor = Color.Parse("#FF333333");
    private readonly Color? _lightDefaultFallbackColor = Colors.White;

    internal Color? _darkInnerFillColor = Color.Parse("#FF33C2B0");
    internal Color? _darkInnerStrokeColor = Color.Parse("#FF333333");
    internal Color? _darkOuterFillColor = Color.Parse("#FF54A9FF");
    internal Color? _darkOuterStrokeColor = Color.Parse("#FFFFFFFF");
    internal Color? _darkFallbackColor = Colors.Black;

    internal Color? _lightInnerFillColor = Color.Parse("#FF00B3A1");
    internal Color? _lightInnerStrokeColor = Color.Parse("#FFFFFFFF");
    internal Color? _lightOuterFillColor = Color.Parse("#FF0077FA");
    internal Color? _lightOuterStrokeColor = Color.Parse("#FF333333");
    internal Color? _lightFallbackColor = Colors.White;
    private ThemeVariant? _currentThemeVariant;

    [ObservableProperty] private Color? _fallbackColor = Colors.White;
    [ObservableProperty] private Color? _innerFillColor = Color.Parse("#43CCF8");
    [ObservableProperty] private Color? _innerStrokeColor = Color.Parse("#FFF");
    [ObservableProperty] private Color? _outerFillColor = Color.Parse("#2F88FF");
    [ObservableProperty] private Color? _outerStrokeColor = Color.Parse("#333");
    [ObservableProperty] private double _size;
    [ObservableProperty] private double _strokeWidth;

    public IconParkSettingPanelViewModel()
    {
        ResetCommand = new RelayCommand(Reset);
        WeakReferenceMessenger.Default.Register<IconParkSettingPanelViewModel, ThemeVariant>(this, OnActualThemeChanged);
        Size = 24;
        StrokeWidth = 2;
    }

    public ICommand ResetCommand { get; set; }

    partial void OnInnerFillColorChanged(Color? value)
    {
        WeakReferenceMessenger.Default.Send(new ColorResourceChangeMessage(value, nameof(InnerFillColor)),
            MessengerChannels.IconPark);
        if(_currentThemeVariant == ThemeVariant.Light)
        {
            _lightInnerFillColor = InnerFillColor;
        }
        else if (_currentThemeVariant == ThemeVariant.Dark)
        {
            _darkInnerFillColor = InnerFillColor;
        }
    }

    partial void OnInnerStrokeColorChanged(Color? value)
    {
        WeakReferenceMessenger.Default.Send(new ColorResourceChangeMessage(value, nameof(InnerStrokeColor)),
            MessengerChannels.IconPark);
        if (_currentThemeVariant == ThemeVariant.Light)
        {
             _lightInnerStrokeColor = InnerStrokeColor;
        }
        else if (_currentThemeVariant == ThemeVariant.Dark)
        {
            _darkInnerStrokeColor = InnerStrokeColor;
        }
    }

    partial void OnOuterFillColorChanged(Color? value)
    {
        WeakReferenceMessenger.Default.Send(new ColorResourceChangeMessage(value, nameof(OuterFillColor)),
            MessengerChannels.IconPark);
        if (_currentThemeVariant == ThemeVariant.Light)
        {
             _lightOuterFillColor = OuterFillColor;
        }
        else if (_currentThemeVariant == ThemeVariant.Dark)
        {
            _darkOuterFillColor = OuterFillColor;
        }
    }

    partial void OnOuterStrokeColorChanged(Color? value)
    {
        WeakReferenceMessenger.Default.Send(new ColorResourceChangeMessage(value, nameof(OuterStrokeColor)),
            MessengerChannels.IconPark);
        if (_currentThemeVariant == ThemeVariant.Light)
        {
             _lightOuterStrokeColor = OuterStrokeColor;
        }
        else if (_currentThemeVariant == ThemeVariant.Dark)
        {
            _darkOuterStrokeColor = OuterStrokeColor;
        }
    }

    partial void OnFallbackColorChanged(Color? value)
    {
        WeakReferenceMessenger.Default.Send(new ColorResourceChangeMessage(value, nameof(FallbackColor)),
            MessengerChannels.IconPark);
        if (_currentThemeVariant == ThemeVariant.Light)
        {
            _lightFallbackColor = FallbackColor;
        }
        else if (_currentThemeVariant == ThemeVariant.Dark)
        {
            _darkFallbackColor = FallbackColor;
        }
    }
    
    partial void OnSizeChanged(double value)
    {
        WeakReferenceMessenger.Default.Send(new SizeResourceChangeMessage(value), MessengerChannels.IconPark);
    }
    
    partial void OnStrokeWidthChanged(double value)
    {
        WeakReferenceMessenger.Default.Send(new StrokeWidthResourceChangeMessage(value), MessengerChannels.IconPark);
    }
    
    partial void OnSelectedModeChanged(IconMode value)
    {
        WeakReferenceMessenger.Default.Send(new ModeResourceChangeMessage(value), MessengerChannels.IconPark);
    }
    



    private void Reset()
    {
        if (_currentThemeVariant == ThemeVariant.Light)
        {
            InnerFillColor = _lightDefaultInnerFillColor;
            InnerStrokeColor = _lightDefaultInnerStrokeColor;
            OuterFillColor = _lightDefaultOuterFillColor;
            OuterStrokeColor = _lightDefaultOuterStrokeColor;
            FallbackColor = _lightDefaultFallbackColor;
        }
        else if (_currentThemeVariant == ThemeVariant.Dark)
        {
            InnerFillColor = _darkDefaultInnerFillColor;
            InnerStrokeColor = _darkDefaultInnerStrokeColor;
            OuterFillColor = _darkDefaultOuterFillColor;
            OuterStrokeColor = _darkDefaultOuterStrokeColor;
            FallbackColor = _darkDefaultFallbackColor;
        }
    }

    private void OnActualThemeChanged(IconParkSettingPanelViewModel recipient, ThemeVariant message)
    {
        _currentThemeVariant = message;
        if (message == ThemeVariant.Light)
        {
            InnerFillColor = _lightInnerFillColor;
            InnerStrokeColor = _lightInnerStrokeColor;
            OuterFillColor = _lightOuterFillColor;
            OuterStrokeColor = _lightOuterStrokeColor;
            FallbackColor = _lightFallbackColor;
        }
        else if (message == ThemeVariant.Dark)
        {
            InnerFillColor = _darkInnerFillColor;
            InnerStrokeColor = _darkInnerStrokeColor;
            OuterFillColor = _darkOuterFillColor;
            OuterStrokeColor = _darkOuterStrokeColor;
            FallbackColor = _darkFallbackColor;
        }
    }

    #region Modes

    [ObservableProperty] private IconMode _selectedMode;

    [ObservableProperty] private ObservableCollection<IconMode> _modes =
        [IconMode.Line, IconMode.Fill, IconMode.TwoTone, IconMode.MultiColor];

    #endregion

    #region IExportSettings

    public string XmlNamespace => "https://irihi.tech/iconica/iconpark";
    public string ElementPrefix => "iconpark";
    public string StyleSelector => "iconpark|IconParkBase";
    public string Mode => SelectedMode.ToString();

    public IReadOnlyList<ExportColor> ExportColors =>
    [
        new ("OuterFill", _lightOuterFillColor!.Value.ToString(), _darkOuterFillColor!.Value.ToString()),
        new ("OuterStroke", _lightOuterStrokeColor!.Value.ToString(), _darkOuterStrokeColor!.Value.ToString()),
        new ("InnerFill", _lightInnerFillColor!.Value.ToString(), _darkInnerFillColor!.Value.ToString()),
        new ("InnerStroke", _lightInnerStrokeColor!.Value.ToString(), _darkInnerStrokeColor!.Value.ToString()),
        new ("FallbackBrush", _lightFallbackColor!.Value.ToString(), _darkFallbackColor!.Value.ToString())
    ];

    #endregion
}
