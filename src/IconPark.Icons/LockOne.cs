using Avalonia.Media;

namespace IconPark.Icons;

public class LockOne: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M31 18V11C31 7.13401 27.866 4 24 4V4C20.134 4 17 7.13401 17 11V18")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M24 26L24 34")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
