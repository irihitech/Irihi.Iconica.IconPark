using Avalonia.Media;

namespace IconPark.Icons;

public class SoapBubble: IconParkIconBase
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
                "M26 24C27.3333 24.1667 30 25 31 29")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
