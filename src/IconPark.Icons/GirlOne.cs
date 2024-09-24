using Avalonia.Media;

namespace IconPark.Icons;

public class GirlOne: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M27 24H21L8 44H40L27 24Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
