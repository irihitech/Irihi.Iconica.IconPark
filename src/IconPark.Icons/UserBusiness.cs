using Avalonia.Media;

namespace IconPark.Icons;

public class UserBusiness: IconParkIconBase
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
                "M42 44C42 34.0589 33.9411 26 24 26C14.0589 26 6 34.0589 6 44")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            FillIndex = 1,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M24 44L28 39L24 26L20 39L24 44Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
