using Avalonia.Media;

namespace IconPark.Icons;

public class Ipad: IconParkIconBase
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
                "M22 36L26 36")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
