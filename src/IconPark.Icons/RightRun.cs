using Avalonia.Media;

namespace IconPark.Icons;

public class RightRun: IconParkIconBase
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
                "M13 17L17 20.7895L13.3333 25")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M31 23L35 26.7895L31.3333 31")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
