using Avalonia.Media;

namespace IconPark.Icons;

public class Pie: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            FillIndex = 1,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M24 4C26.5207 4 29.0188 4.47652 31.3625 5.40447L24 24V4Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
