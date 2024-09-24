using Avalonia.Media;

namespace IconPark.Icons;

public class Hamburger: IconParkIconBase
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
                "M44 22C44 12.0589 35.0457 4 24 4C12.9543 4 4 12.0589 4 22H44Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M4 28L9.45455 32L16.7273 28L24 32L31.2727 28L38.5455 32L44 28")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
