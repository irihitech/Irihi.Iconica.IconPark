using Avalonia.Media;

namespace IconPark.Icons;

public class CarouselVideo: IconParkIconBase
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
                "M22 20L28 24L22 28V20Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
