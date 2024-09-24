using Avalonia.Media;

namespace IconPark.Icons;

public class ShoppingBagOne: IconParkIconBase
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
                "M30 18V10C30 6.68629 27.3137 4 24 4V4C20.6863 4 18 6.68629 18 10V18")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
