using Avalonia.Media;

namespace IconPark.Icons;

public class Sketch: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M18.6 16H29.4L33 20.7059L24 32L15 20.7059L18.6 16Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
