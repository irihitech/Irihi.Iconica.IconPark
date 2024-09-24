using Avalonia.Media;

namespace IconPark.Icons;

public class ReverseOperationIn: IconParkIconBase
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
                "M13 17L17 20.7895L13.3333 25")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 2,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M35 23L31 26.7895L34.6667 31")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
