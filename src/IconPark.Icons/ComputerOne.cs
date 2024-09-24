using Avalonia.Media;

namespace IconPark.Icons;

public class ComputerOne: IconParkIconBase
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
                "M10 6C10 4.89543 10.8954 4 12 4H36C37.1046 4 38 4.89543 38 6V42C38 43.1046 37.1046 44 36 44H12C10.8954 44 10 43.1046 10 42L10 6Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M17 12L31 12")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
