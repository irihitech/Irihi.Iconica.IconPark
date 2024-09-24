using Avalonia.Media;

namespace IconPark.Icons;

public class Minus: IconParkIconBase
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
                "M10.5 24L38.5 24")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
