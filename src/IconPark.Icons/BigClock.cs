using Avalonia.Media;

namespace IconPark.Icons;

public class BigClock: IconParkIconBase
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
                "M24 4C12.9543 4 4 12.8648 4 23.8V44H44V23.8C44 12.8648 35.0457 4 24 4Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 2,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M24 18V24L28 28")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
