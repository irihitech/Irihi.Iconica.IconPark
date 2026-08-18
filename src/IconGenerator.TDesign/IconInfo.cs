namespace IconGenerator.TDesign;

public class IconInfo
{
    public string Name { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string CategoryCN { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public List<string> Keywords { get; set; } = [];
}

public record IconMeta(string Category, string CategoryCN, List<string> Keywords);
