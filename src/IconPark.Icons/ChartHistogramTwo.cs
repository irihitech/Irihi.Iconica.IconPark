using Avalonia.Media;

namespace IconPark.Icons;

public class ChartHistogramTwo: IconParkIconBase
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
                "M4 42H44H4Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M4 42H44")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
