using Avalonia.Media;

namespace IconPark.Icons;

public class Cancer: IconParkIconBase
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
                "M6 13C6 13 12 5 22 5C32 5 38 11 38 11")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M42 35C42 35 36 43 26 43C16 43 10 37 10 37")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
