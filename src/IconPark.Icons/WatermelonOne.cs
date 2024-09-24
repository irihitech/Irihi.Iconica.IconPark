using Avalonia.Media;

namespace IconPark.Icons;

public class WatermelonOne: IconParkIconBase
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
                "M24 4L41 33.92C41 33.92 36.0457 38 24 38C11.9543 38 7 33.92 7 33.92L24 4Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M41 39.9199C41 39.9199 36.0457 43.9999 24 43.9999C11.9543 43.9999 7 39.9199 7 39.9199")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
