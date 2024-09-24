using Avalonia.Media;

namespace IconPark.Icons;

public class HandleZ: IconParkIconBase
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
                "M14 16H34L14 32H34")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
