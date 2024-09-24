using Avalonia.Media;

namespace IconPark.Icons;

public class NodeRound: IconParkIconBase
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
                "M24 42V27M42 24H27")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M42 6H24C14.0589 6 6 14.0589 6 24V42")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
