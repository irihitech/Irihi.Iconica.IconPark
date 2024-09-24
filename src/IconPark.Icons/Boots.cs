using Avalonia.Media;

namespace IconPark.Icons;

public class Boots: IconParkIconBase
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
                "M19 4H35L31 36L32.2361 36.618C33.93 37.465 35 39.1963 35 41.0902V44H10V42L23 36L19 4Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M20 12H34")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
