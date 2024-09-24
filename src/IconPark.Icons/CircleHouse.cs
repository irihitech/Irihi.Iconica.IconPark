using Avalonia.Media;

namespace IconPark.Icons;

public class CircleHouse: IconParkIconBase
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
                "M44 23H4C4 23 14.5 17 19 12C23.5 7 24.5 4 24.5 4C24.5 4 25.5 7 30 12C34.5 17 44 23 44 23Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
