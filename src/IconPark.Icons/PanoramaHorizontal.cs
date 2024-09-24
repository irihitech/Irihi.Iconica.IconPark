using Avalonia.Media;

namespace IconPark.Icons;

public class PanoramaHorizontal: IconParkIconBase
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
                "M4 11C4 11 13 15 24 15C35 15 44 11 44 11V37C44 37 35 33 24 33C13 33 4 37 4 37V11Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
