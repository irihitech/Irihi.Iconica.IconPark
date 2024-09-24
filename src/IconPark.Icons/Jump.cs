using Avalonia.Media;

namespace IconPark.Icons;

public class Jump: IconParkIconBase
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
                "M8 10L20 20.254V29.9683L10.8571 44")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M40 10L28 20.254V29.9683L37.1429 44")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
