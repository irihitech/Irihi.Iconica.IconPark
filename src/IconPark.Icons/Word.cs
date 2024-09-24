using Avalonia.Media;

namespace IconPark.Icons;

public class Word: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 2,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M14 16L18 32L24 19L30 32L34 16")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
