using Avalonia.Media;

namespace IconPark.Icons;

public class FiveKey: IconParkIconBase
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
                "M29 14.0093H20V21.0341C20 21 22 20 25 20C28 20 29 22.0339 29 26C29 29.9661 28 33 24 33C21 33 20 31 20 29.0078")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
