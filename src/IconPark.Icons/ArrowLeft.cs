using Avalonia.Media;

namespace IconPark.Icons;

public class ArrowLeft: IconParkIconBase
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
                "M5.79889 24H41.7989")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M17.7988 36L5.79883 24L17.7988 12")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
