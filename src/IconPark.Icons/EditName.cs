using Avalonia.Media;

namespace IconPark.Icons;

public class EditName: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M4 41C4 32.1634 12.0589 25 22 25")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M31 42L41 32L37 28L27 38V42H31Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
