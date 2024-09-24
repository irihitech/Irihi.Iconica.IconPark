using Avalonia.Media;

namespace IconPark.Icons;

public class HoneyOne: IconParkIconBase
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
                "M25.0029 28.4238L29.169 24.106L43.5756 38.0062L39.4095 42.3241L25.0029 28.4238Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M21 40.25C21 42.3211 19.2091 44 17 44C14.7909 44 13 42.3211 13 40.25C13 38.1789 17 34 17 34C17 34 21 38.1789 21 40.25Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
