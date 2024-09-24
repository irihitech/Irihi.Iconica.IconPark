using Avalonia.Media;

namespace IconPark.Icons;

public class Box: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 2,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M17.9497 24.0083L29.9497 24.0083")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M6 13L13 5H35L42 13")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
