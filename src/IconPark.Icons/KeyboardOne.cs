using Avalonia.Media;

namespace IconPark.Icons;

public class KeyboardOne: IconParkIconBase
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
                "M17 36H31")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M33 18V13.125C33 12.5727 33.4477 12.125 34 12.125H39C39.5523 12.125 40 11.6773 40 11.125V6")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
