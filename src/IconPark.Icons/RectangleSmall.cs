using Avalonia.Media;

namespace IconPark.Icons;

public class RectangleSmall: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M36 14H12C10.8954 14 10 14.8954 10 16V32C10 33.1046 10.8954 34 12 34H36C37.1046 34 38 33.1046 38 32V16C38 14.8954 37.1046 14 36 14Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
