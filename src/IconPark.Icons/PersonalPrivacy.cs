using Avalonia.Media;

namespace IconPark.Icons;

public class PersonalPrivacy: IconParkIconBase
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
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M37 31V28C37 26.3431 35.6569 25 34 25C32.3431 25 31 26.3431 31 28V31")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
