using Avalonia.Media;

namespace IconPark.Icons;

public class Waves: IconParkIconBase
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
                "M2 23.3548H11L17.8889 4L28.8889 44L37 23.3548H46")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
