using Avalonia.Media;

namespace IconPark.Icons;

public class Shield: IconParkIconBase
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
                "M6 8.25564L24.0086 3L42 8.25564V19.0337C42 30.3622 34.7502 40.4194 24.0026 44.0005C13.2521 40.4195 6 30.36 6 19.0287V8.25564Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
