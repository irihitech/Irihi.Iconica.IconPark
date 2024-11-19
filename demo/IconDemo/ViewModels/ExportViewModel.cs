using System;
using System.Text;
using Avalonia.Metadata;
using CommunityToolkit.Mvvm.ComponentModel;
using IconDemo.Models;

namespace IconDemo.ViewModels;

public partial class ExportViewModel: ObservableObject
{
    private SettingPanelViewModel _settingPanelViewModel;
    private IconInfo? _iconInfo;
    
    [ObservableProperty] private string? _globalStyle;
    [ObservableProperty] private string? _globalResource;
    [ObservableProperty] private string? _icon;
    [ObservableProperty] private bool _useLocalColor;
    [ObservableProperty] private bool _hasIconInfo;
    
    public ExportViewModel(SettingPanelViewModel settingPanelViewModel, IconInfo? iconType)
    {
        _settingPanelViewModel = settingPanelViewModel;
        _iconInfo = iconType;
        _hasIconInfo = iconType != null;
        GenerateGlobalStyle();
        GenerateGlobalResource();
        GenerateIcon();
    }

    private void GenerateGlobalStyle()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("<Style Selector=\":is(iconica|IconicaBase)\">");
        sb.AppendLine($"    <Setter Property=\"OuterFill\" Value=\"{{DynamicResource IconOuterFillBrush}}\" />");
        sb.AppendLine($"    <Setter Property=\"OuterStroke\" Value=\"{{DynamicResource IconOuterStrokeBrush}}\" />");
        sb.AppendLine($"    <Setter Property=\"InnerFill\" Value=\"{{DynamicResource IconInnerFillBrush}}\" />");
        sb.AppendLine($"    <Setter Property=\"InnerStroke\" Value=\"{{DynamicResource IconInnerStrokeBrush}}\" />");
        sb.AppendLine($"    <Setter Property=\"FallbackBrush\" Value=\"{{DynamicResource IconFallbackBrush}}\" />");
        sb.AppendLine("</Style>");
        GlobalStyle = sb.ToString();
    }
    
    private void GenerateGlobalResource()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("<ResourceDictionary>");
        sb.AppendLine("    <ResourceDictionary.ThemeDictionaries>");
        sb.AppendLine("        <ResourceDictionary x:Key=\"Light\">");
        sb.AppendLine($"            <SolidColorBrush x:Key=\"IconOuterFillBrush\" Color=\"{_settingPanelViewModel._lightOuterFillColor}\" />");
        sb.AppendLine($"            <SolidColorBrush x:Key=\"IconOuterStrokeBrush\" Color=\"{_settingPanelViewModel._lightOuterStrokeColor}\" />");
        sb.AppendLine($"            <SolidColorBrush x:Key=\"IconInnerFillBrush\" Color=\"{_settingPanelViewModel._lightInnerFillColor}\" />");
        sb.AppendLine($"            <SolidColorBrush x:Key=\"IconInnerStrokeBrush\" Color=\"{_settingPanelViewModel._lightInnerStrokeColor}\" />");
        sb.AppendLine($"            <SolidColorBrush x:Key=\"IconFallbackBrush\" Color=\"{_settingPanelViewModel._lightFallbackColor}\" />");
        sb.AppendLine("        </ResourceDictionary>");
        sb.AppendLine("        <ResourceDictionary x:Key=\"Dark\">");
        sb.AppendLine($"            <SolidColorBrush x:Key=\"IconOuterFillBrush\" Color=\"{_settingPanelViewModel._darkOuterFillColor}\" />");
        sb.AppendLine($"            <SolidColorBrush x:Key=\"IconOuterStrokeBrush\" Color=\"{_settingPanelViewModel._darkOuterStrokeColor}\" />");
        sb.AppendLine($"            <SolidColorBrush x:Key=\"IconInnerFillBrush\" Color=\"{_settingPanelViewModel._darkInnerFillColor}\" />");
        sb.AppendLine($"            <SolidColorBrush x:Key=\"IconInnerStrokeBrush\" Color=\"{_settingPanelViewModel._darkInnerStrokeColor}\" />");
        sb.AppendLine($"            <SolidColorBrush x:Key=\"IconFallbackBrush\" Color=\"{_settingPanelViewModel._darkFallbackColor}\" />");
        sb.AppendLine("        </ResourceDictionary>");
        sb.AppendLine("    </ResourceDictionary.ThemeDictionaries>");
        sb.AppendLine("</ResourceDictionary>");
        GlobalResource = sb.ToString();
    }
    
    private void GenerateIcon()
    {
        if (_iconInfo is null) return;
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"<iconica:{_iconInfo.ClassName} Width=\"{_settingPanelViewModel.Size}\" Height=\"{_settingPanelViewModel.Size}\"");
        if (UseLocalColor)
        {
            sb.AppendLine($"    OuterFill=\"{{DynamicResource IconOuterFillBrush}}\"");
            sb.AppendLine($"    OuterStroke=\"{{DynamicResource IconOuterStrokeBrush}}\"");
            sb.AppendLine($"    InnerFill=\"{{DynamicResource IconInnerFillBrush}}\"");
            sb.AppendLine($"    InnerStroke=\"{{DynamicResource IconInnerStrokeBrush}}\"");
            sb.AppendLine($"    FallbackBrush=\"{{DynamicResource IconFallbackBrush}}\"");
        }
        sb.AppendLine($"    StrokeWidth=\"{_settingPanelViewModel.StrokeWidth}\"");
        sb.AppendLine($"    LineCap=\"Round\"");
        sb.AppendLine($"    LineJoin=\"Round\"");
        sb.AppendLine($"    Mode=\"{(_settingPanelViewModel.SelectedMode)}\"");
        sb.AppendLine("    />");
        Icon = sb.ToString();
    }
    
    partial void OnUseLocalColorChanged(bool value)
    {
        GenerateIcon();
    }
    
}