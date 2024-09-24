using Avalonia.Media;

namespace IconPark.Icons;

public class Formula: IconParkIconBase
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
                "M40 9L37 6H8L26 24L8 42H37L40 39")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
