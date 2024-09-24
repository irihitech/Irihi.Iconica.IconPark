using Avalonia.Media;

namespace IconPark.Icons;

public class UmbrellaTwo: IconParkIconBase
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
                "M27 24V37.125C27 39 26.6379 44 23 44C19.5714 44 19 39.625 19 38.375")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M24 4C38.5 4 43.375 17.3333 44 24H4C4.625 17.3333 9.5 4 24 4Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M19 14L23 18L29 11")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
