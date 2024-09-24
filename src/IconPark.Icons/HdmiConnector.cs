using Avalonia.Media;

namespace IconPark.Icons;

public class HdmiConnector: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 2,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M29 43C29 40.2386 26.7614 38 24 38C21.2386 38 19 40.2386 19 43")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M15.5 42.1091C18.0797 43.3221 20.9607 44 24 44C27.0393 44 29.9203 43.3221 32.5 42.1091")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
