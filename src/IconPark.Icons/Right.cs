using Avalonia.Media;

namespace IconPark.Icons;

public class Right: IconParkIconBase
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
                "M19 12L31 24L19 36")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
