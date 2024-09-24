// See https://aka.ms/new-console-template for more information

using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

string rootPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", ".."));
var svgPath = Path.Combine(rootPath, "iconpark", "packages", "react", "src", "icons");
var fileNames = Directory.GetFiles(svgPath, "*.tsx");
var sourceTargetPath = Path.Combine(rootPath, "src", "IconPark.Icons");


var length = fileNames.Length;

static string GenerateDocument(string name, List<PathData> data)
{
    var sb = new StringBuilder();
    sb.AppendLine("using Avalonia.Media;");
    sb.AppendLine();
    sb.AppendLine("namespace IconPark.Icons;");
    sb.AppendLine();
    sb.AppendLine($"public class {name}: IconParkIconBase");
    sb.AppendLine("{");
    sb.AppendLine("    private static readonly DrawingElement[]? StaticDrawingData =");
    sb.AppendLine("    [");

    foreach (var pathData in data)
    {
        sb.AppendLine("        new PathDrawingElement()");
        sb.AppendLine("        {");
        sb.AppendLine($"            StrokeIndex = {pathData.StrokeIndex},");
        if (pathData.FillIndex >= 0)
        {
            sb.AppendLine($"            FillIndex = {pathData.FillIndex},");
        }
        sb.AppendLine($"            InheritStrokeWidth = {pathData.InheritStrokeWidth.ToString().ToLower()},");
        sb.AppendLine($"            InheritStrokeCap = {pathData.InheritStrokeCap.ToString().ToLower()},");
        sb.AppendLine($"            InheritStrokeJoin = {pathData.InheritStrokeJoin.ToString().ToLower()},");
        sb.AppendLine($"            Data = StreamGeometry.Parse(");
        sb.AppendLine($"                \"{pathData.Data}\")");
        sb.AppendLine("        },");
    }

    sb.AppendLine("    ];");
    sb.AppendLine();
    sb.AppendLine("    protected override DrawingElement[]? DrawingData => StaticDrawingData;");
    sb.AppendLine("}");

    return sb.ToString();
}

foreach (var fileName in fileNames)
{
    var name = Path.GetFileNameWithoutExtension(fileName);
    var fileContent = await File.ReadAllTextAsync(fileName);
    var match = Regex.Matches(fileContent, @"<svg\b[^>]*>([\s\S]*?)<\/svg>");
    XmlDocument xmlDoc = new XmlDocument();
    string value = match.First().Value;
    value = value.Replace("{", "\"{");
    value = value.Replace("}", "}\"");
    xmlDoc.LoadXml(value);
    // Find all <path> elements
    var pathNodes = xmlDoc.SelectNodes("svg/path | g/path");
    if (pathNodes?.Count is null or 0)
    {
        continue;
    }
    List<PathData> list = new List<PathData>();
    foreach (var pathNode in pathNodes)
    {
        var path = (XmlElement)pathNode;
        var d = path.GetAttribute("d");
        var id = path.GetAttribute("id");
        var fill = path.GetAttribute("fill");
        var stroke = path.GetAttribute("stroke");
        var strokeWidth = path.GetAttribute("strokeWidth");
        var strokeLineCap = path.GetAttribute("strokeLinecap");
        var transform = path.GetAttribute("transform");
        var fillIndex = fill.Length > 0 ? fill[^2] - '0' : -1;
        var strokeIndex = stroke.Length > 0 ? stroke[^2] - '0' : -1;
        bool inheritStrokeWidth = strokeWidth?.Length > 0;
        bool inheritStrokeCap = strokeLineCap?.Length > 0;
        bool inheritStrokeJoin = strokeLineCap?.Length > 0;
        
        var pathData = new PathData
        {
            Data = d,
            FillIndex = fillIndex,
            StrokeIndex = strokeIndex,
            InheritStrokeWidth = inheritStrokeWidth,
            InheritStrokeCap = inheritStrokeCap,
            InheritStrokeJoin = inheritStrokeJoin,
            Transform = transform
        };
        list.Add(pathData);
    }
    
    var sourceCode = GenerateDocument(name, list);
    
    var targetPath = Path.Combine(sourceTargetPath, $"{name}.cs");
    
    await File.WriteAllTextAsync(targetPath, sourceCode);
}



class PathData
{
    public int StrokeIndex { get; set; } = -1;
    public int FillIndex { get; set; } = -1;
    public bool InheritStrokeWidth { get; set; }
    public bool InheritStrokeCap { get; set; }
    public bool InheritStrokeJoin { get; set; }
    public string? Transform { get; set; }
    public string? Data { get; set; }
}
