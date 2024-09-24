using Avalonia.Media;

namespace IconPark.Icons;

public class Phonograph: IconParkIconBase
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
                "M28 20L36 12")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
