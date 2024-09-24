using Avalonia.Media;

namespace IconPark.Icons;

public class RedCross: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 2,
            FillIndex = 3,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M27 12H21V21L12 21V27H21V36H27V27L36 27V21H27V12Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
