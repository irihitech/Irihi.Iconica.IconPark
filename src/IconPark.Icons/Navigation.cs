using Avalonia.Media;

namespace IconPark.Icons;

public class Navigation: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M24.5 4L9 44L24.5 34.9091L40 44L24.5 4Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
