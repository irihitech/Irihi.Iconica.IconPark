using Avalonia.Media;

namespace IconPark.Icons;

public class Division: IconParkIconBase
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
                "M44 24L4 24")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
