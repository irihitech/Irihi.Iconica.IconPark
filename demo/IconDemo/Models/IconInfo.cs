using System;
using System.Collections.Generic;
using Avalonia.Controls;

namespace IconDemo.Models;

public partial class IconInfo
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string CategoryChinese { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public List<string> Tag { get; set; } = [];
    public bool Rtl { get; set; }
    public string ClassName { get; set; } = string.Empty;
    public Func<Control>? Creator { get; set; }
    public List<string> Keywords { get; set; } = [];
    public Type IconType { get; set; }

    /// <summary>TDesign 图标是否 Filled 变体（类名以 Filled 结尾）。</summary>
    public static bool IsFilled(IconInfo icon) => icon.ClassName.EndsWith("Filled", StringComparison.Ordinal);

    /// <summary>TDesign 图标是否 Outline 变体。</summary>
    public static bool IsOutline(IconInfo icon) => !IsFilled(icon);
}