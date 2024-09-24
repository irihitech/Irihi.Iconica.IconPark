using Avalonia.Media;

namespace IconPark.Icons;

public class DoneAll: IconParkIconBase
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
                "M14 24L15.25 25.25M44 14L24 34L22.75 32.75")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M4 24L14 34L34 14")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
