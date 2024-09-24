using Avalonia.Media;

namespace IconPark.Icons;

public class LinkThree: IconParkIconBase
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
                "M31.0723 16.929L16.9301 31.0711")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
