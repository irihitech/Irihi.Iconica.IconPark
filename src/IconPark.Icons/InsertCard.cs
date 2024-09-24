using Avalonia.Media;

namespace IconPark.Icons;

public class InsertCard: IconParkIconBase
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
                "M10 18H4L4 6H44V18H38")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            FillIndex = 1,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M12 12L4 41H44L36 12H12Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
