using Avalonia.Media;

namespace IconPark.Icons;

public class Master: IconParkIconBase
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
                "M38 38V6C38 4.89543 37.1046 4 36 4H12C10.8954 4 10 4.89543 10 6V38")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            FillIndex = 1,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M20 16L24 12L28 16L32 12L29 23H19L16 12L20 16Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
