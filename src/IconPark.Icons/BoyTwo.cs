using Avalonia.Media;

namespace IconPark.Icons;

public class BoyTwo: IconParkIconBase
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
                "M31 44V35L36 32L32 19C32 19 28 16 24 16C20 16 16 19 16 19L12 31L17 35V44")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
