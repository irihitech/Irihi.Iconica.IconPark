using Avalonia.Media;

namespace IconPark.Icons;

public class Check: IconParkIconBase
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
                "M43 11L16.875 37L5 25.1818")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
