using Avalonia.Media;

namespace IconPark.Icons;

public class Videocamera: IconParkIconBase
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
                "M36 29L44 33V15L36 19")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
