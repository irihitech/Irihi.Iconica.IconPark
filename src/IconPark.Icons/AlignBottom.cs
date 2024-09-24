using Avalonia.Media;

namespace IconPark.Icons;

public class AlignBottom: IconParkIconBase
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
                "M42 42H6")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
