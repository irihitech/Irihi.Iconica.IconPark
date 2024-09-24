using Avalonia.Media;

namespace IconPark.Icons;

public class DownTwo: IconParkIconBase
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
                "M5 24L24 42L43 24H31V6H17V24H5Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
