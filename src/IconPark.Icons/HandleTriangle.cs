using Avalonia.Media;

namespace IconPark.Icons;

public class HandleTriangle: IconParkIconBase
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
                "M12 31L24 11L36 31H12Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
