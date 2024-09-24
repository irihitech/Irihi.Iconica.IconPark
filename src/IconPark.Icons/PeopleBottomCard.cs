using Avalonia.Media;

namespace IconPark.Icons;

public class PeopleBottomCard: IconParkIconBase
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
                "M44 39H4V9H19L24 4L29 9H44V39Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M33 33C33 28.5817 28.9706 25 24 25C19.0294 25 15 28.5817 15 33")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
