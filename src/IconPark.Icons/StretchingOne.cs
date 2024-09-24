using Avalonia.Media;

namespace IconPark.Icons;

public class StretchingOne: IconParkIconBase
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
                "M41 8L29 17.5909V44")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M10.1111 23.25L19 18V28.9167L7 41")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
