using Avalonia.Media;

namespace IconPark.Icons;

public class Gopro: IconParkIconBase
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
                "M18 24H24")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
