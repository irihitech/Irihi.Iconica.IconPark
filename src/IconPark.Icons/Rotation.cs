using Avalonia.Media;

namespace IconPark.Icons;

public class Rotation: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M24 44C35.0457 44 44 35.0457 44 24C44 12.9543 35.0457 4 24 4")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M24 44C12.9543 44 4 35.0457 4 24C4 12.9543 12.9543 4 24 4")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
