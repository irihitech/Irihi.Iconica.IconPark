using Avalonia.Media;

namespace IconPark.Icons;

public class CheckSmall: IconParkIconBase
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
                "M10 24L20 34L40 14")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
