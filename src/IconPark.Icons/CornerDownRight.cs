using Avalonia.Media;

namespace IconPark.Icons;

public class CornerDownRight: IconParkIconBase
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
                "M32 18L40 26L32 34")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M8 10V23C8 24.6569 9.34315 26 11 26H40")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
