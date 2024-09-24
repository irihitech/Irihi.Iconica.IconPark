using Avalonia.Media;

namespace IconPark.Icons;

public class RemoteControl: IconParkIconBase
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
                "M23 24H25")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
