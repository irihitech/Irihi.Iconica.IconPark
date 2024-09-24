using Avalonia.Media;

namespace IconPark.Icons;

public class Filter: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            FillIndex = 1,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M6 9L20.4 25.8178V38.4444L27.6 42V25.8178L42 9H6Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
