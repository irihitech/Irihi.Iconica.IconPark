using Avalonia.Media;

namespace IconPark.Icons;

public class Aquarius: IconParkIconBase
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
                "M4 20L14 8L20 17L28 8L35 19L44 9.04348")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M4 40L14 28L20 37L28 28L35 39L44 29.0435")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
