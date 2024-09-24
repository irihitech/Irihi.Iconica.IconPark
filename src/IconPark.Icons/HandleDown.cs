using Avalonia.Media;

namespace IconPark.Icons;

public class HandleDown: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 2,
            FillIndex = 3,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M34 20L24 30L14 20H34Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
