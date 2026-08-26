using System.Collections.Generic;

namespace Irihi.Iconica.Demo.ViewModels;

/// <summary>
/// 单个颜色通道的导出信息：属性名 + 明暗主题下的颜色值。
/// </summary>
/// <param name="Property">图标控件的属性名，如 OuterFill、Stroke1。</param>
/// <param name="LightColor">Light 主题颜色（Avalonia Color 字符串）。</param>
/// <param name="DarkColor">Dark 主题颜色（Avalonia Color 字符串）。</param>
public record ExportColor(string Property, string LightColor, string DarkColor);

/// <summary>
/// 导出功能所需的设置提供者，由各图标库的设置面板实现，
/// 使 ExportViewModel 能同时支持 IconPark 与 TDesign。
/// </summary>
public interface IExportSettings
{
    double Size { get; }
    double StrokeWidth { get; }

    /// <summary>XAML 命名空间，如 https://irihi.tech/iconica/iconpark。</summary>
    string XmlNamespace { get; }

    /// <summary>XAML 元素前缀，如 iconpark、tdesign。</summary>
    string ElementPrefix { get; }

    /// <summary>样式选择器中的控件类型，如 iconpark|IconParkBase。</summary>
    string StyleSelector { get; }

    /// <summary>当前 Mode 的字符串表示。</summary>
    string Mode { get; }

    /// <summary>颜色通道列表。</summary>
    IReadOnlyList<ExportColor> ExportColors { get; }
}
