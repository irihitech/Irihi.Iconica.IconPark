using Avalonia.Media;

namespace IconPark.Icons;

public class Chinese: IconParkIconBase
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
                "M24 14V35")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
