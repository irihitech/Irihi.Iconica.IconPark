using Avalonia.Media;

namespace IconPark.Icons;

public class LaptopOne: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M8 11C8 9.34315 9.34315 8 11 8H37C38.6569 8 40 9.34315 40 11V32H8V11Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M4 32H44V34C44 37.3137 41.3137 40 38 40H10C6.68629 40 4 37.3137 4 34V32Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
