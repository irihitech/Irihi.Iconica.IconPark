using Avalonia.Media;

namespace IconPark.Icons;

public class CurveAdjustment: IconParkIconBase
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
                "M44 4H4V44H44V4Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M38 10C32 10 27 14 24 24C21 34 16 38 10 38")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
