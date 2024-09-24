using Avalonia.Media;

namespace IconPark.Icons;

public class ReverseOperationOut: IconParkIconBase
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
                "M17 17L13 20.7895L16.6667 25")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 2,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M31 23L35 26.7895L31.3333 31")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
