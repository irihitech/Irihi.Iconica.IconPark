using Avalonia.Media;

namespace IconPark.Icons;

public class RightTwo: IconParkIconBase
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
                "M24 43L42 24L24 5L24 17L6 17V31H24V43Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
