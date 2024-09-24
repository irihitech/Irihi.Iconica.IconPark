using Avalonia.Media;

namespace IconPark.Icons;

public class Powerpoint: IconParkIconBase
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
                "M19 33L19 15")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
