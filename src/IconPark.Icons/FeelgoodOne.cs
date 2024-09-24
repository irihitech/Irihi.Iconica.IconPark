using Avalonia.Media;

namespace IconPark.Icons;

public class FeelgoodOne: IconParkIconBase
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
                "M44 6H4V36H25L35 41V36H44V6Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 2,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M13 23C13 23 17 27 24 27C31 27 35 23 35 23")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
