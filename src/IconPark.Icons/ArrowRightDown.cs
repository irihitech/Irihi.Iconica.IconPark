using Avalonia.Media;

namespace IconPark.Icons;

public class ArrowRightDown: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M37 19V37H19")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M11.5439 11.5439L36.9997 36.9997")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
