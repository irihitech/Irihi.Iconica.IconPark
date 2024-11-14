using System.Text.Json.Serialization;

namespace IconGenerator;

public class IconInfo
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("category")]
    public string Category { get; set; } = string.Empty;

    [JsonPropertyName("categoryCN")]
    public string CategoryCN { get; set; } = string.Empty;

    [JsonPropertyName("author")]
    public string Author { get; set; } = string.Empty;

    [JsonPropertyName("tag")]
    public List<string> Tag { get; set; } = new List<string>();

    [JsonPropertyName("rtl")]
    public bool Rtl { get; set; }

    public string ClassName { get; set; } = string.Empty;
    public bool Valid { get; set; }

}