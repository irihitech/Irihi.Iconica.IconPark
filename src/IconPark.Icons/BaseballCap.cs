using Avalonia.Media;

namespace IconPark.Icons;

public class BaseballCap: IconParkIconBase
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
                "M12 30C12 21.1634 19.1634 14 28 14V14C36.8366 14 44 21.1634 44 30V36H12V30Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M21.9997 36C20.9997 32.5 20.9997 14 27.9997 14C34.9997 14 34.4997 32 33.9997 36")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
