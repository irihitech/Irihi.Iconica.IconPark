using Avalonia.Media;

namespace IconPark.Icons;

public class Bluetooth: IconParkIconBase
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
                "M12 13L34 34L23 44V4L34 14L12 35")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
