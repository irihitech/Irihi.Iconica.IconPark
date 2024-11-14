using System;
using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using IconDemo.Models;

namespace IconDemo.ViewModels;

public partial class IconViewerViewModel : ObservableObject
{
    [ObservableProperty] private List<IconInfo>? _activeIconNames;
    [ObservableProperty] private int _columnCount;
    [ObservableProperty] private List<IconInfo>? _iconNames;
    [ObservableProperty] private string? _searchInput;
    [ObservableProperty] private List<List<IconInfo>> _virtualizedNames = new();

    internal void OnLoad()
    {
        IconNames = IconInfo.IconInfos;
        ActiveIconNames = IconNames;
    }

    partial void OnSearchInputChanged(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            ActiveIconNames = IconNames;
            return;
        }

        ActiveIconNames = IconNames
                          ?.Where(n => n.Keywords.Any(b => b.Contains(value, StringComparison.OrdinalIgnoreCase)))
                          .ToList();
    }

    partial void OnColumnCountChanged(int value)
    {
        var values = VirtualizedNames.SelectMany(a => a).ToList();
        VirtualizedNames = values.Chunk(value).Select(a => a.ToList()).ToList();
    }

    partial void OnActiveIconNamesChanged(List<IconInfo>? value)
    {
        if (value is null || ColumnCount == 0) return;
        VirtualizedNames = value.Chunk(ColumnCount).Select(a => a.ToList()).ToList();
    }
}