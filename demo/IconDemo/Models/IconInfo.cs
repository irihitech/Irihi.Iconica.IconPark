using System;
using System.Collections.Generic;
using Irihi.Iconica;
using Irihi.Iconica.Icons;

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
    public Func<IconicaBase>? Creator { get; set; }
    public List<string> Keywords { get; set; } = [];
    public Type IconType { get; set; }
}