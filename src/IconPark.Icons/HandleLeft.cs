using Avalonia.Media;

namespace IconPark.Icons;

public class HandleLeft: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 2,
            FillIndex = 3,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M28 34L18 24L28 14V34Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
