using Avalonia.Media;

namespace IconPark.Icons;

public class Skates: IconParkIconBase
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
                "M5 5H31V13H5V5Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M9 36V13H27V23C41 23 41 32 41 36H9Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
