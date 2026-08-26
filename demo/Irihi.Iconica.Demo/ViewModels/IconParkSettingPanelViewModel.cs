using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Media;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Irihi.Iconica.Demo.Messages;
using Irihi.Iconica.IconPark;

namespace Irihi.Iconica.Demo.ViewModels;

public partial class IconParkSettingPanelViewModel : ObservableObject, IExportSettings
{
    private readonly Color? _lightDefaultOuterStrokeColor = Color.Parse("#333333");
    private readonly Color? _lightDefaultOuterFillColor = Color.Parse("#0077FA");
    private readonly Color? _lightDefaultInnerStrokeColor = Color.Parse("#FFFFFF");
    private readonly Color? _lightDefaultInnerFillColor = Color.Parse("#00B3A1");
    private readonly Color? _lightDefaultFallbackColor = Colors.White;

    private readonly Color? _darkDefaultOuterStrokeColor = Color.Parse("#FFFFFF");
    private readonly Color? _darkDefaultOuterFillColor = Color.Parse("#54A9FF");
    private readonly Color? _darkDefaultInnerStrokeColor = Color.Parse("#333333");
    private readonly Color? _darkDefaultInnerFillColor = Color.Parse("#33C2B0");
    private readonly Color? _darkDefaultFallbackColor = Colors.Black;

    internal Color? _lightOuterStrokeColor = Color.Parse("#333333");
    internal Color? _lightOuterFillColor = Color.Parse("#0077FA");
    internal Color? _lightInnerStrokeColor = Color.Parse("#FFFFFF");
    internal Color? _lightInnerFillColor = Color.Parse("#00B3A1");
    internal Color? _lightFallbackColor = Colors.White;

    internal Color? _darkOuterStrokeColor = Color.Parse("#FFFFFF");
    internal Color? _darkOuterFillColor = Color.Parse("#54A9FF");
    internal Color? _darkInnerStrokeColor = Color.Parse("#333333");
    internal Color? _darkInnerFillColor = Color.Parse("#33C2B0");
    internal Color? _darkFallbackColor = Colors.Black;

    private ThemeVariant? _currentThemeVariant;

    [ObservableProperty] public partial Color? OuterStrokeColor { get; set; } = Color.Parse("#333");
    [ObservableProperty] public partial Color? OuterFillColor { get; set; } = Color.Parse("#2F88FF");
    [ObservableProperty] public partial Color? InnerStrokeColor { get; set; } = Color.Parse("#FFFFFF");
    [ObservableProperty] public partial Color? InnerFillColor { get; set; } = Color.Parse("#43CCF8");
    [ObservableProperty] public partial Color? FallbackColor { get; set; } = Colors.White;
    [ObservableProperty] public partial double Size { get; set; }
    [ObservableProperty] public partial double StrokeWidth { get; set; }

    public IconParkSettingPanelViewModel()
    {
        WeakReferenceMessenger.Default.Register<IconParkSettingPanelViewModel, ThemeVariant>(this, OnActualThemeChanged);
        Size = 24;
        StrokeWidth = 4;
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

    partial void OnInnerFillColorChanged(Color? value)
    {
        WeakReferenceMessenger.Default.Send(new ColorResourceChangeMessage(value, nameof(InnerFillColor)),
            MessengerChannels.IconPark);
        if (_currentThemeVariant == ThemeVariant.Light)
        {
            _lightInnerFillColor = InnerFillColor;
        }
        else if (_currentThemeVariant == ThemeVariant.Dark)
        {
            _darkInnerFillColor = InnerFillColor;
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

    [RelayCommand]
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

    [ObservableProperty] public partial IconMode SelectedMode { get; set; }

    public ObservableCollection<IconMode> Modes { get; set; } =
        [IconMode.Line, IconMode.Fill, IconMode.TwoTone, IconMode.MultiColor];

    #endregion

    #region IExportSettings

    public string XmlNamespace => "https://irihi.tech/iconica/iconpark";
    public string ElementPrefix => "iconpark";
    public string StyleSelector => "iconpark|IconParkBase";
    public string Mode => SelectedMode.ToString();

    public IReadOnlyList<ExportColor> ExportColors =>
    [
        new("OuterStroke", _lightOuterStrokeColor!.Value.ToString(), _darkOuterStrokeColor!.Value.ToString()),
        new("OuterFill", _lightOuterFillColor!.Value.ToString(), _darkOuterFillColor!.Value.ToString()),
        new("InnerStroke", _lightInnerStrokeColor!.Value.ToString(), _darkInnerStrokeColor!.Value.ToString()),
        new("InnerFill", _lightInnerFillColor!.Value.ToString(), _darkInnerFillColor!.Value.ToString()),
        new("FallbackBrush", _lightFallbackColor!.Value.ToString(), _darkFallbackColor!.Value.ToString())
    ];

    #endregion
}