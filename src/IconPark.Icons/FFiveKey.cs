using Avalonia.Media;

namespace IconPark.Icons;

public class FFiveKey: IconParkIconBase
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
                "M34 16H26V22.9185C26 22.9185 27.8333 21.5 30.5 21.5C33.1667 21.5 34 23.6585 34 27C34 30.3415 32.5 32 29.5556 32C26.8889 32 26 30.315 26 28.6365")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M21 16H14V32")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M14 24H21")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
