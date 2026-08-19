using System;
using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using IconDemo.Models;

namespace IconDemo.ViewModels;

public partial class IconViewerViewModel : ObservableObject
{
    private readonly IReadOnlyList<IconInfo> _source;

    [ObservableProperty] private List<IconInfo>? _activeIconNames;
    [ObservableProperty] private int _columnCount;
    [ObservableProperty] private List<IconInfo>? _iconNames;
    [ObservableProperty] private string? _searchInput;
    [ObservableProperty] private string _title;
    [ObservableProperty] private Func<IconInfo, bool>? _filter;
    [ObservableProperty] private List<List<IconInfo>> _virtualizedNames = new();

    public IconViewerViewModel(IReadOnlyList<IconInfo> source, string title)
    {
        _source = source;
        _title = title;
    }

    internal void OnLoad()
    {
        Reload();
    }

    partial void OnFilterChanged(Func<IconInfo, bool>? value)
    {
        Reload();
    }

    private void Reload()
    {
        var filtered = _source.Where(Filter ?? (_ => true)).ToList();
        IconNames = filtered;
        ActiveIconNames = ApplySearch(filtered);
    }

    partial void OnSearchInputChanged(string? value)
    {
        ActiveIconNames = ApplySearch(IconNames ?? []);
    }

    private List<IconInfo> ApplySearch(IEnumerable<IconInfo> source)
    {
        if (string.IsNullOrWhiteSpace(SearchInput))
        {
            return [.. source];
        }

        return source
               .Where(n => n.Keywords.Any(b => b.Contains(SearchInput, StringComparison.OrdinalIgnoreCase)))
               .ToList();
    }

    partial void OnColumnCountChanged(int value)
    {
        if (ColumnCount == 0) return;
        var values = VirtualizedNames.SelectMany(a => a).ToList();
        VirtualizedNames = values.Chunk(value).Select(a => a.ToList()).ToList();
    }

    partial void OnActiveIconNamesChanged(List<IconInfo>? value)
    {
        if (value is null || ColumnCount == 0) return;
        VirtualizedNames = value.Chunk(ColumnCount).Select(a => a.ToList()).ToList();
    }
}
