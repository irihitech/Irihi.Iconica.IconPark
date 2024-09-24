using Avalonia.Media;

namespace IconPark.Icons;

public class VideocameraOne: IconParkIconBase
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
                "M35 35L44 39V23L35 27")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
