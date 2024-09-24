using Avalonia.Media;

namespace IconPark.Icons;

public class Tower: IconParkIconBase
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
                "M4 44H44")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
