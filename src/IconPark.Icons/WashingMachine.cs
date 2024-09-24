using Avalonia.Media;

namespace IconPark.Icons;

public class WashingMachine: IconParkIconBase
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
                "M8.77783 15.5H40.7778")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
