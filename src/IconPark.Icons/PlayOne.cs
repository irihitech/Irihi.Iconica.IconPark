using Avalonia.Media;

namespace IconPark.Icons;

public class PlayOne: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            FillIndex = 1,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M15 24V11.8756L25.5 17.9378L36 24L25.5 30.0622L15 36.1244V24Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
