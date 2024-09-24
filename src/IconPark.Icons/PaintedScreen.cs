using Avalonia.Media;

namespace IconPark.Icons;

public class PaintedScreen: IconParkIconBase
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
                "M13 24L13 17")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
