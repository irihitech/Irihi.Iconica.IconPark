using Avalonia.Media;

namespace IconPark.Icons;

public class TicketsTwo: IconParkIconBase
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
                "M30 30C33 30 35 31.8809 35 34L41 34L41 4L35 4C35 6 33 8 30 8C27 8 25 6 25 4L19 4L19 18")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M30 44L24 44C24 41.8809 22 40 19 40C16 40 14 41.8809 14 44L8 44L8 14L14 14C14 16 16 18 19 18C22 18 24 16 24 14L30 14L30 44Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
