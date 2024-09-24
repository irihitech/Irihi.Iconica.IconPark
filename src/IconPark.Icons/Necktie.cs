using Avalonia.Media;

namespace IconPark.Icons;

public class Necktie: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M15 36L21 13H27L33 36L24 44L15 36Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M21 4H27L30 6L27 13H21L18 6L21 4Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
