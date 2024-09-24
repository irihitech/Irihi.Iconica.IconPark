using Avalonia.Media;

namespace IconPark.Icons;

public class RightSmallDown: IconParkIconBase
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
                "M32.3535 32.3535L15.3535 15.3535")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M32.3535 14.3535V32.3535H14.3535")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
