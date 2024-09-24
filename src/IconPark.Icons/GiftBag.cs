using Avalonia.Media;

namespace IconPark.Icons;

public class GiftBag: IconParkIconBase
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
                "M6 32H42V39C42 40.6569 40.6569 42 39 42H9C7.34315 42 6 40.6569 6 39V32Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M17 20L24 14L31 20")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
