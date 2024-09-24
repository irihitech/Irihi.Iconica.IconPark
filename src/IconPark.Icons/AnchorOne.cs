using Avalonia.Media;

namespace IconPark.Icons;

public class AnchorOne: IconParkIconBase
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
                "M40 35C40 25.7953 32.8366 10 24 10C15.1634 10 8 25.7953 8 35")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M12 10H36")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
