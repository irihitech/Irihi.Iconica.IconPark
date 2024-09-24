using Avalonia.Media;

namespace IconPark.Icons;

public class AlignTop: IconParkIconBase
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
                "M42 6.5H6")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
