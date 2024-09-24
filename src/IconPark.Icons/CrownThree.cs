using Avalonia.Media;

namespace IconPark.Icons;

public class CrownThree: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M13 42H35L41 21L31 26L24 12L17 26L7 21L13 42Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
