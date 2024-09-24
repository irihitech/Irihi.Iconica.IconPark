using Avalonia.Media;

namespace IconPark.Icons;

public class Renault: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            FillIndex = 1,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M30 4H18L8 24H17L22 14H26L31 24H40L30 4Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            FillIndex = 1,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M30 44H18L8 24H17L22 34H26L31 24H40L30 44Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
