using Avalonia.Media;

namespace IconPark.Icons;

public class Snacks: IconParkIconBase
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
                "M6 14H42V8H38L36 4H12L10 8H6V14Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M36 44L38 14H10L12 44H36Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
