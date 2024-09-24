using Avalonia.Media;

namespace IconPark.Icons;

public class StereoOne: IconParkIconBase
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
                "M9 18H39")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
