using Avalonia.Media;

namespace IconPark.Icons;

public class RightUser: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M42 44C42 34.0589 33.9411 26 24 26C14.0589 26 6 34.0589 6 44")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M30 36L22 44L18 40")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
