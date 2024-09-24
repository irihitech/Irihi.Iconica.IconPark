using Avalonia.Media;

namespace IconPark.Icons;

public class PlayTwo: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M18.5 24V16.2058L25.25 20.1029L32 24L25.25 27.8971L18.5 31.7942V24Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
