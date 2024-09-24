using Avalonia.Media;

namespace IconPark.Icons;

public class MultiRectangle: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M12 39H44V7H12V15")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M8 39H32V15H8V23")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M20 23H4V39H20V23Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
