using Avalonia;
using Avalonia.Media;

namespace Irihi.Iconica;

public abstract class DrawingElement
{
    public int StrokeIndex { get; set; } = -1;
    public int FillIndex { get; set; } = -1;
    public bool InheritStrokeWidth { get; set; }
    public bool InheritStrokeCap { get; set; }
    public bool InheritStrokeJoin { get; set; }
    public Matrix? Transform { get; set; }
}

public class PathDrawingElement : DrawingElement
{
    public Geometry? Data { get; set; }
}

public class EllipseDrawingElement : DrawingElement
{
    public double RadiusX { get; set; }
    public double RadiusY { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
}

public class LineDrawingElement : DrawingElement
{
    public double X1 { get; set; }
    public double Y1 { get; set; }
    public double X2 { get; set; }
    public double Y2 { get; set; }
}

public class RectDrawingElement : DrawingElement
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public double? Rx { get; set; }
    public double? Ry { get; set; }
}