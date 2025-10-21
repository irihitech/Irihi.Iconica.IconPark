using CommunityToolkit.Mvvm.ComponentModel;
using IconDemo.Models;

namespace IconDemo.ViewModels;

public partial class ExportViewModel : ObservableObject
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
        GlobalStyle =
            """
            <Style Selector=":is(iconpark|IconParkBase)">
                <Setter Property="OuterFill" Value="{{DynamicResource IconOuterFillBrush}}" />
                <Setter Property="OuterStroke" Value="{{DynamicResource IconOuterStrokeBrush}}" />
                <Setter Property="InnerFill" Value="{{DynamicResource IconInnerFillBrush}}" />
                <Setter Property="InnerStroke" Value="{{DynamicResource IconInnerStrokeBrush}}" />
                <Setter Property="FallbackBrush" Value="{{DynamicResource IconFallbackBrush}}" />
            </Style>
            """;
    }

    private void GenerateGlobalResource()
    {
        GlobalResource =
            $"""
             <ResourceDictionary>
                 <ResourceDictionary.ThemeDictionaries>
                     <ResourceDictionary x:Key="Light">
                         <SolidColorBrush x:Key="IconOuterFillBrush" Color="{_settingPanelViewModel._lightOuterFillColor}" />
                         <SolidColorBrush x:Key="IconOuterStrokeBrush" Color="{_settingPanelViewModel._lightOuterStrokeColor}" />
                         <SolidColorBrush x:Key="IconInnerFillBrush" Color="{_settingPanelViewModel._lightInnerFillColor}" />
                         <SolidColorBrush x:Key="IconInnerStrokeBrush" Color="{_settingPanelViewModel._lightInnerStrokeColor}" />
                         <SolidColorBrush x:Key="IconFallbackBrush" Color="{_settingPanelViewModel._lightFallbackColor}" />
                     </ResourceDictionary>
                     <ResourceDictionary x:Key="Dark">
                         <SolidColorBrush x:Key="IconOuterFillBrush" Color="{_settingPanelViewModel._darkOuterFillColor}" />
                         <SolidColorBrush x:Key="IconOuterStrokeBrush" Color="{_settingPanelViewModel._darkOuterStrokeColor}" />
                         <SolidColorBrush x:Key="IconInnerFillBrush" Color="{_settingPanelViewModel._darkInnerFillColor}" />
                         <SolidColorBrush x:Key="IconInnerStrokeBrush" Color="{_settingPanelViewModel._darkInnerStrokeColor}" />
                         <SolidColorBrush x:Key="IconFallbackBrush" Color="{_settingPanelViewModel._darkFallbackColor}" />
                     </ResourceDictionary>
                 </ResourceDictionary.ThemeDictionaries>
             </ResourceDictionary>
             """;
    }

    private void GenerateIcon()
    {
        if (_iconInfo is null) return;
        var element =
            $"""
             <iconpark:{_iconInfo.ClassName}
                 Width="{_settingPanelViewModel.Size}"
                 Height="{_settingPanelViewModel.Size}"
             """;
        if (UseLocalColor)
        {
            element =
                $$$"""
                   {{{element}}}
                       OuterFill="{{DynamicResource IconOuterFillBrush}}"
                       OuterStroke="{{DynamicResource IconOuterStrokeBrush}}"
                       InnerFill="{{DynamicResource IconInnerFillBrush}}"
                       InnerStroke="{{DynamicResource IconInnerStrokeBrush}}"
                       FallbackBrush="{{DynamicResource IconFallbackBrush}}"
                   """;
        }

        element =
            $"""
             {element}
                 StrokeWidth="{_settingPanelViewModel.StrokeWidth}"
                 LineCap="Round"
                 LineJoin="Round"
                 Mode="{_settingPanelViewModel.SelectedMode}" />
             """;
        Icon = element;
    }

    partial void OnUseLocalColorChanged(bool value)
    {
        GenerateIcon();
    }
}