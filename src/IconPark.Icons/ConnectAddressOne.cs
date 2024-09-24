using Avalonia.Media;

namespace IconPark.Icons;

public class ConnectAddressOne: IconParkIconBase
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
                "M6 24C6 33.9411 14.0589 42 24 42C33.9411 42 42 33.9411 42 24")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M24 14L24 42")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
