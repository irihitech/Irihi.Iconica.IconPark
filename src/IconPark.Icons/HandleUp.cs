using Avalonia.Media;

namespace IconPark.Icons;

public class HandleUp: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 2,
            FillIndex = 3,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M14 28L24 18L34 28H14Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
