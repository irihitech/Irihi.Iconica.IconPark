using Avalonia.Media;

namespace IconPark.Icons;

public class Lightning: IconParkIconBase
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
                "M19 4H37L26 18H41L17 44L22 25H8L19 4Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
