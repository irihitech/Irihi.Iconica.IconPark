using Avalonia.Media;

namespace IconPark.Icons;

public class UTurnDown: IconParkIconBase
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
                "M35 34V15C35 8.92487 30.0751 4 24 4V4C17.9249 4 13 8.92487 13 15V44")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M18 39L13 44L8 39")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
