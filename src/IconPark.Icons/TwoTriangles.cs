using Avalonia.Media;

namespace IconPark.Icons;

public class TwoTriangles: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = -1,
            FillIndex = 1,
            InheritStrokeWidth = false,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M24.0002 4L41.3207 34H6.67969L24.0002 4Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = -1,
            FillIndex = 1,
            InheritStrokeWidth = false,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M24.0002 44L41.3207 14H6.67969L24.0002 44Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M24.0002 4L41.3207 34H6.67969L24.0002 4Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M24.0002 44L41.3207 14H6.67969L24.0002 44Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
