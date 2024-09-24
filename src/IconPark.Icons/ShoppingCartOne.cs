using Avalonia.Media;

namespace IconPark.Icons;

public class ShoppingCartOne: IconParkIconBase
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
                "M5 6L14 12L19 34H39L44 17H25")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M25 26L32.2727 26L41 26")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
