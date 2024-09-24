using Avalonia.Media;

namespace IconPark.Icons;

public class BottleThree: IconParkIconBase
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
                "M21.1875 10H26.8125L33 21.1806V44H15V21.1806L21.1875 10Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
