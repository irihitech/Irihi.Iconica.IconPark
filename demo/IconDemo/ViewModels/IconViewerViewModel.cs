using System;
using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using IconDemo.Models;

namespace IconDemo.ViewModels;

public partial class IconViewerViewModel : ObservableObject
{
    private readonly IReadOnlyList<IconInfo> _source;

    [ObservableProperty] private List<IconCategoryGroup> _groups = [];
    [ObservableProperty] private List<IconInfo>? _activeIconNames;
    [ObservableProperty] private List<IconInfo>? _iconNames;
    [ObservableProperty] private string? _searchInput;
    [ObservableProperty] private string _title;
    [ObservableProperty] private Func<IconInfo, bool>? _filter;

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

        return source.Where(n =>
                n.CategoryChinese.Contains(SearchInput, StringComparison.OrdinalIgnoreCase) ||
                n.Category.Contains(SearchInput, StringComparison.OrdinalIgnoreCase) ||
                n.Keywords.Any(b => b.Contains(SearchInput, StringComparison.OrdinalIgnoreCase)))
            .ToList();
    }


    partial void OnActiveIconNamesChanged(List<IconInfo>? value)
    {
        if (value is null) return;
        RebuildGroups();
    }

    private void RebuildGroups()
    {
        Groups = ActiveIconNames!
            .GroupBy(i => i.Category)
            .Select(g => new IconCategoryGroup(g.Key, g.First().CategoryChinese, g.ToList()))
            .ToList();
    }
}