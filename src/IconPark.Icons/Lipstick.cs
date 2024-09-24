using Avalonia.Media;

namespace IconPark.Icons;

public class Lipstick: IconParkIconBase
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
                "M10 11.4545V24H18V4C11.5 4 10 9.63636 10 11.4545Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M7 32L21 32")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
