using System.Collections.Generic;

namespace IconDemo.Models;

public class IconCategoryGroup
{
    public IconCategoryGroup(string category, string categoryChinese, List<IconInfo> icons)
    {
        Category = category;
        CategoryChinese = categoryChinese;
        Items = icons;
    }

    public string Category { get; }

    public string CategoryChinese { get; }

    public List<IconInfo> Items { get; }

    public string CategoryDisplay => $"{CategoryChinese} ({Items.Count})";
}