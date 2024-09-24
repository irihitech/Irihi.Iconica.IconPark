using Avalonia.Media;

namespace IconPark.Icons;

public class SendOne: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M42 6L4 20.1383L24 24.0083L29.0052 44L42 6Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M24.0083 24.0084L29.6651 18.3516")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
