using Avalonia.Media;

namespace IconPark.Icons;

public class CornerLeftDown: IconParkIconBase
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
                "M12 34L20 42L28 34")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M36 10H23C21.3431 10 20 11.3431 20 13V42")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
