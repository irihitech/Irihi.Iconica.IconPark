using Avalonia.Media;

namespace IconPark.Icons;

public class AlignRight: IconParkIconBase
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
                "M42 6V42")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
