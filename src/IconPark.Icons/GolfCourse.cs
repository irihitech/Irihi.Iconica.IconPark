using Avalonia.Media;

namespace IconPark.Icons;

public class GolfCourse: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = -1,
            FillIndex = 45,
            InheritStrokeWidth = false,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M24 9L13 4V14L24 9Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M13 34V14M13 14V4L24 9L13 14Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
