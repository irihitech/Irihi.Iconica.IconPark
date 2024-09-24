using Avalonia.Media;

namespace IconPark.Icons;

public class Steoller: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            FillIndex = 1,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M40 24H12L14.5 34H36L40 24Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M12 24L8 15H3.5")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            FillIndex = 1,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M23 8.0002L28 24.0002H40C40 24.0002 43.5 16.0002 37.5 10.0002C31.5 4.00022 25.6667 6.66686 23 8.0002Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
