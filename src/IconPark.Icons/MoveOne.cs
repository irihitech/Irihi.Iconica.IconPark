using Avalonia.Media;

namespace IconPark.Icons;

public class MoveOne: IconParkIconBase
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
                "M8 6L43 25L24 27L13.9948 44L8 6Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
