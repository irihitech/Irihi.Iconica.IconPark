using Avalonia.Media;

namespace IconPark.Icons;

public class HandleRight: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M20 14L30 24L20 34V14Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
