using Avalonia.Media;

namespace IconPark.Icons;

public class RightExpand: IconParkIconBase
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
                "M6 6V42")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
