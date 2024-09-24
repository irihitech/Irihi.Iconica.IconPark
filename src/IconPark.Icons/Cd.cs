using Avalonia.Media;

namespace IconPark.Icons;

public class Cd: IconParkIconBase
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
                "M13 24C13 17.9249 17.9249 13 24 13")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
