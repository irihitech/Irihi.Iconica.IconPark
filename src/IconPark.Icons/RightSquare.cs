using Avalonia.Media;

namespace IconPark.Icons;

public class RightSquare: IconParkIconBase
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
                "M19 14L29 24L19 34")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
