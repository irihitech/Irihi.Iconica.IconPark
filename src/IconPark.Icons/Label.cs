using Avalonia.Media;

namespace IconPark.Icons;

public class Label: IconParkIconBase
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
                "M9 4H39V44L24 33.4286L9 44V4Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
