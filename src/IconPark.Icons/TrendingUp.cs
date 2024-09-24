using Avalonia.Media;

namespace IconPark.Icons;

public class TrendingUp: IconParkIconBase
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
                "M40.9999 27.0005V15.0005H29")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M6 37L16.3385 24.5L26.1846 30.5L41 15")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
