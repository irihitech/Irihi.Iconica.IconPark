using Avalonia.Media;

namespace IconPark.Icons;

public class CornerRightDown: IconParkIconBase
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
                "M20 34L28 42L36 34")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M12 10H25C26.6569 10 28 11.3431 28 13V42")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
