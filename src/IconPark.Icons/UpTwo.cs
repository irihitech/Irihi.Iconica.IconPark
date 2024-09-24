using Avalonia.Media;

namespace IconPark.Icons;

public class UpTwo: IconParkIconBase
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
                "M5 24L24 6L43 24H31V42H17V24H5Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
