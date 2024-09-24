using Avalonia.Media;

namespace IconPark.Icons;

public class Taurus: IconParkIconBase
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
                "M44 8C44 15.732 35.0457 22 24 22C12.9543 22 4 15.732 4 8")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
