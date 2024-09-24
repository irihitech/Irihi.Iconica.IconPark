using Avalonia.Media;

namespace IconPark.Icons;

public class UpSquare: IconParkIconBase
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
                "M14 29L24 19L34 29")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
