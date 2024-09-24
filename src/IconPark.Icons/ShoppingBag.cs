using Avalonia.Media;

namespace IconPark.Icons;

public class ShoppingBag: IconParkIconBase
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
                "M5 17H43L38.8 43H9.2L5 17Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M35 17C35 10.3726 30.0751 5 24 5C17.9249 5 13 10.3726 13 17")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M18 33C18 33 20 36 24 36C28 36 30 33 30 33")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
