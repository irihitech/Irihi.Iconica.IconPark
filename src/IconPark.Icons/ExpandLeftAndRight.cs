using Avalonia.Media;

namespace IconPark.Icons;

public class ExpandLeftAndRight: IconParkIconBase
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
                "M42 6V42M16 20L12 24L16 28M32 20L36 24L32 28M24 6L24 42M6 6L6 42")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
