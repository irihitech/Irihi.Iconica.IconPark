using Avalonia.Media;

namespace IconPark.Icons;

public class STurnRight: IconParkIconBase
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
                "M30 24L13 24C9 24 6 21 6 17C6 13 9 10 13 10L32 10")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M8 38L35 38C39 38 42 35 42 31C42 27 39 24 35 24L30 24")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M13 43L8 38L13 33")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
