using Avalonia.Media;

namespace IconPark.Icons;

public class Tuchong: IconParkIconBase
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
                "M5 39H43V28H37V33H11V15H23V9H5V39Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M43 16V22C35 22 29 17 29 9H35C35 13 37 16 43 16Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
