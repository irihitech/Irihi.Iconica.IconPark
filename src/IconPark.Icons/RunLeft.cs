using Avalonia.Media;

namespace IconPark.Icons;

public class RunLeft: IconParkIconBase
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
                "M17 17L13 20.7895L16.6667 25")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 2,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M35 23L31 26.7895L34.6667 31")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
