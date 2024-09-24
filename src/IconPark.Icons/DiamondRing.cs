using Avalonia.Media;

namespace IconPark.Icons;

public class DiamondRing: IconParkIconBase
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
                "M18 8L21 4H25.1339H29.0536L32 8L25 14L18 8Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
