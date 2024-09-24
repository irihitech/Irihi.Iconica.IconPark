using Avalonia.Media;

namespace IconPark.Icons;

public class OneKey: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 2,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M21.2261 18L26.0001 13.0166V34")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
