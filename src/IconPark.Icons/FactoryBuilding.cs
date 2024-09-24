using Avalonia.Media;

namespace IconPark.Icons;

public class FactoryBuilding: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            FillIndex = 1,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M4 44V4H12V20L28 12V20L44 12V44H4Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
