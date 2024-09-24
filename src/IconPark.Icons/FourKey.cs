using Avalonia.Media;

namespace IconPark.Icons;

public class FourKey: IconParkIconBase
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
                "M26.9767 34V14L18 26.9967V29.0199H30")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
