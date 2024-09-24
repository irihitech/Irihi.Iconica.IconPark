using Avalonia.Media;

namespace IconPark.Icons;

public class RightBranchOne: IconParkIconBase
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
                "M6 24L22 24")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M42 8H30C25.5817 8 22 11.5817 22 16V32C22 36.4183 25.5817 40 30 40H42")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
