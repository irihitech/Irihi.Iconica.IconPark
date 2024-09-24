using Avalonia.Media;

namespace IconPark.Icons;

public class LeftOne: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            FillIndex = 1,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M30 36L18 24L30 12V36Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
