using Avalonia.Media;

namespace IconPark.Icons;

public class IpadOne: IconParkIconBase
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
                "M11 27V23")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
