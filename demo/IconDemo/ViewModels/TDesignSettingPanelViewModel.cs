using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Media;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using IconDemo.Messages;
using Irihi.Iconica.TDesign;

namespace IconDemo.ViewModels;

public partial class TDesignSettingPanelViewModel : ObservableObject, IExportSettings
{
    private readonly Color? _lightDefaultFill1Color = Color.Parse("#02D8F2");
    private readonly Color? _lightDefaultFill2Color = Color.Parse("#FFAA75");
    private readonly Color? _lightDefaultStroke1Color = Colors.Black;
    private readonly Color? _lightDefaultStroke2Color = Color.Parse("#0262F8");
    private readonly Color? _lightDefaultFallbackColor = Colors.Black;

    private readonly Color? _darkDefaultFill1Color = Color.Parse("#02D8F2");
    private readonly Color? _darkDefaultFill2Color = Color.Parse("#FFAA75");
    private readonly Color? _darkDefaultStroke1Color = Colors.White;
    private readonly Color? _darkDefaultStroke2Color = Color.Parse("#0262F8");
    private readonly Color? _darkDefaultFallbackColor = Colors.White;

    internal Color? _lightFill1Color = Color.Parse("#02D8F2");
    internal Color? _lightFill2Color = Color.Parse("#FFAA75");
    internal Color? _lightStroke1Color = Colors.Black;
    internal Color? _lightStroke2Color = Color.Parse("#0262F8");
    internal Color? _lightFallbackColor = Colors.Black;

    internal Color? _darkFill1Color = Color.Parse("#02D8F2");
    internal Color? _darkFill2Color = Color.Parse("#FFAA75");
    internal Color? _darkStroke1Color = Colors.White;
    internal Color? _darkStroke2Color = Color.Parse("#0262F8");
    internal Color? _darkFallbackColor = Colors.White;

    private ThemeVariant? _currentThemeVariant;

    [ObservableProperty] private Color? _fill1Color = Color.Parse("#02D8F2");
    [ObservableProperty] private Color? _fill2Color = Color.Parse("#FFAA75");
    [ObservableProperty] private Color? _stroke1Color = Colors.Black;
    [ObservableProperty] private Color? _stroke2Color = Color.Parse("#0262F8");
    [ObservableProperty] private Color? _fallbackColor = Colors.Black;
    [ObservableProperty] private double _size;
    [ObservableProperty] private double _strokeWidth;

    public TDesignSettingPanelViewModel()
    {
        WeakReferenceMessenger.Default.Register<TDesignSettingPanelViewModel, ThemeVariant>(this, OnActualThemeChanged);
        Size = 24;
        StrokeWidth = 2;
    }

    partial void OnFill1ColorChanged(Color? value)
    {
        WeakReferenceMessenger.Default.Send(new ColorResourceChangeMessage(value, nameof(Fill1Color)),
            MessengerChannels.TDesign);
        SaveToThemeCache(value, ref _lightFill1Color, ref _darkFill1Color);
    }

    partial void OnFill2ColorChanged(Color? value)
    {
        WeakReferenceMessenger.Default.Send(new ColorResourceChangeMessage(value, nameof(Fill2Color)),
            MessengerChannels.TDesign);
        SaveToThemeCache(value, ref _lightFill2Color, ref _darkFill2Color);
    }

    partial void OnStroke1ColorChanged(Color? value)
    {
        WeakReferenceMessenger.Default.Send(new ColorResourceChangeMessage(value, nameof(Stroke1Color)),
            MessengerChannels.TDesign);
        SaveToThemeCache(value, ref _lightStroke1Color, ref _darkStroke1Color);
    }

    partial void OnStroke2ColorChanged(Color? value)
    {
        WeakReferenceMessenger.Default.Send(new ColorResourceChangeMessage(value, nameof(Stroke2Color)),
            MessengerChannels.TDesign);
        SaveToThemeCache(value, ref _lightStroke2Color, ref _darkStroke2Color);
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
        WeakReferenceMessenger.Default.Send(new SizeResourceChangeMessage(value), MessengerChannels.TDesign);
    }

    partial void OnStrokeWidthChanged(double value)
    {
        WeakReferenceMessenger.Default.Send(new StrokeWidthResourceChangeMessage(value), MessengerChannels.TDesign);
    }

    partial void OnSelectedModeChanged(IconMode value)
    {
        WeakReferenceMessenger.Default.Send(new TDesignModeResourceChangeMessage(value), MessengerChannels.TDesign);
    }

    partial void OnSelectedVariantChanged(IconVariant value)
    {
        WeakReferenceMessenger.Default.Send(new TDesignVariantResourceChangeMessage(value), MessengerChannels.TDesign);
    }

    private void SaveToThemeCache(Color? value, ref Color? light, ref Color? dark)
    {
        if (_currentThemeVariant == ThemeVariant.Light)
        {
            light = value;
        }
        else if (_currentThemeVariant == ThemeVariant.Dark)
        {
            dark = value;
        }
    }

    [RelayCommand]
    private void Reset()
    {
        if (_currentThemeVariant == ThemeVariant.Light)
        {
            Stroke1Color = _lightDefaultStroke1Color;
            Fill1Color = _lightDefaultFill1Color;
            Stroke2Color = _lightDefaultStroke2Color;
            Fill2Color = _lightDefaultFill2Color;
            FallbackColor = _lightDefaultFallbackColor;
        }
        else if (_currentThemeVariant == ThemeVariant.Dark)
        {
            Stroke1Color = _darkDefaultStroke1Color;
            Fill1Color = _darkDefaultFill1Color;
            Stroke2Color = _darkDefaultStroke2Color;
            Fill2Color = _darkDefaultFill2Color;
            FallbackColor = _darkDefaultFallbackColor;
        }
    }

    private void OnActualThemeChanged(TDesignSettingPanelViewModel recipient, ThemeVariant message)
    {
        _currentThemeVariant = message;
        if (message == ThemeVariant.Light)
        {
            Fill1Color = _lightFill1Color;
            Fill2Color = _lightFill2Color;
            Stroke1Color = _lightStroke1Color;
            Stroke2Color = _lightStroke2Color;
            FallbackColor = _lightFallbackColor;
        }
        else if (message == ThemeVariant.Dark)
        {
            Fill1Color = _darkFill1Color;
            Fill2Color = _darkFill2Color;
            Stroke1Color = _darkStroke1Color;
            Stroke2Color = _darkStroke2Color;
            FallbackColor = _darkFallbackColor;
        }
    }

    #region Modes

    [ObservableProperty] private IconMode _selectedMode = IconMode.FilledDouble;

    public ObservableCollection<IconMode> Modes { get; set; } =
        [IconMode.OutlineSingle, IconMode.OutlineDouble, IconMode.FilledDouble, IconMode.FilledMultiple];

    #endregion

    #region Variants

    [ObservableProperty] private IconVariant _selectedVariant = IconVariant.Outline;

    public ObservableCollection<IconVariant> Variants { get; set; } =
        [IconVariant.Outline, IconVariant.Filled];

    #endregion

    #region IExportSettings

    public string XmlNamespace => "https://irihi.tech/iconica/tdesign";
    public string ElementPrefix => "tdesign";
    public string StyleSelector => "tdesign|TDesignIconBase";
    public string Mode => SelectedMode.ToString();

    public IReadOnlyList<ExportColor> ExportColors =>
    [
        new("Fill1", _lightFill1Color!.Value.ToString(), _darkFill1Color!.Value.ToString()),
        new("Fill2", _lightFill2Color!.Value.ToString(), _darkFill2Color!.Value.ToString()),
        new("Stroke1", _lightStroke1Color!.Value.ToString(), _darkStroke1Color!.Value.ToString()),
        new("Stroke2", _lightStroke2Color!.Value.ToString(), _darkStroke2Color!.Value.ToString())
    ];

    #endregion
}