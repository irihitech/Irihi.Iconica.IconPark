using Avalonia.Media;

namespace IconPark.Icons;

public class CameraOne: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M17 31L11 43H37L31 31")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
