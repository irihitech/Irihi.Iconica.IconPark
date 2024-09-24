using Avalonia.Media;

namespace IconPark.Icons;

public class LeftSquare: IconParkIconBase
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
                "M29 34L19 24L29 14")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
