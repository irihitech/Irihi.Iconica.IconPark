using Avalonia.Media;

namespace IconPark.Icons;

public class Left: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M31 36L19 24L31 12")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
