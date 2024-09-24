using Avalonia.Media;

namespace IconPark.Icons;

public class Deer: IconParkIconBase
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
                "M36 27C36 34.2165 30.6274 44 24 44C17.3726 44 12 34.2165 12 27C12 19.7835 13.5 16 24 16C34.5 16 36 19.7835 36 27Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M12 4C12 10.6274 17.3726 16 24 16C30.6274 16 36 10.6274 36 4")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M18 7C18 11.9706 20.6863 16 24 16C27.3137 16 30 11.9706 30 7")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
