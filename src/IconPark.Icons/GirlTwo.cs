using Avalonia.Media;

namespace IconPark.Icons;

public class GirlTwo: IconParkIconBase
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
                "M28 44V36H38L27.2308 16H20.7692L10 36H20V44")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
