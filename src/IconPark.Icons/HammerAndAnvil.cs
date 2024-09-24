using Avalonia.Media;

namespace IconPark.Icons;

public class HammerAndAnvil: IconParkIconBase
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
                "M6 14C6 4 14 4 14 4V24H6C6 24 6 24 6 14Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M6 30H42C42 30 42 38 36 38C30 38 29 38 29 38L31 44H13L15 38H6V30Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
