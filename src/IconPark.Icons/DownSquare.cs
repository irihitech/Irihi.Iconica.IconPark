using Avalonia.Media;

namespace IconPark.Icons;

public class DownSquare: IconParkIconBase
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
                "M34 19L24 29L14 19")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
