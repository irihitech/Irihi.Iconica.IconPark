using Avalonia.Media;

namespace IconPark.Icons;

public class EndpointRound: IconParkIconBase
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
                "M42 24L26 24")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M42 40H22C13.1634 40 6 32.8366 6 24C6 15.1634 13.1634 8 22 8H42")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
