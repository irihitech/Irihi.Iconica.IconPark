using Avalonia.Media;

namespace IconPark.Icons;

public class Shopping: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = -1,
            FillIndex = 45,
            InheritStrokeWidth = false,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M39 32H13L8 12H44L39 32Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M3 6H6.5L8 12M8 12L13 32H39L44 12H8Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
