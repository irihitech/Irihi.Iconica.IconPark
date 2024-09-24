using Avalonia.Media;

namespace IconPark.Icons;

public class SevenKey: IconParkIconBase
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
                "M18.9983 15H29L20.9939 33")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
