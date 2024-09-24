using Avalonia.Media;

namespace IconPark.Icons;

public class BoyOne: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            FillIndex = 1,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M27 44H21L8 24H40L27 44Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
