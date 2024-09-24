using Avalonia.Media;

namespace IconPark.Icons;

public class Up: IconParkIconBase
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
                "M13 30L25 18L37 30")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
