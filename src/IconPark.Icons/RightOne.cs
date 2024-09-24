using Avalonia.Media;

namespace IconPark.Icons;

public class RightOne: IconParkIconBase
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
                "M20 12L32 24L20 36V12Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
