using Avalonia.Media;

namespace IconPark.Icons;

public class Pumpkin: IconParkIconBase
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
                "M30 6H27C25.3431 6 24 7.34315 24 9V14")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
