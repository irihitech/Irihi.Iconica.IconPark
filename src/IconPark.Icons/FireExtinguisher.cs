using Avalonia.Media;

namespace IconPark.Icons;

public class FireExtinguisher: IconParkIconBase
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
                "M6 20C6 15.5817 9.58172 12 14 12C18.4183 12 22 15.5817 22 20V44H6V20Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = -1,
            FillIndex = 45,
            InheritStrokeWidth = false,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M30 44H42L36 26L30 44Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M36 26L30 44H42L36 26ZM36 26V24C36 16.4575 36 12.6863 33.6569 10.3431C31.3137 8 27.5425 8 20 8H18M10 8H6")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
