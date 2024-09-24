using Avalonia.Media;

namespace IconPark.Icons;

public class AlignLeft: IconParkIconBase
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
                "M6.5 6V42")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
