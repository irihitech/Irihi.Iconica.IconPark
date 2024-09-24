using Avalonia.Media;

namespace IconPark.Icons;

public class UpOne: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            FillIndex = 1,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M12 29L24 17L36 29H12Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
