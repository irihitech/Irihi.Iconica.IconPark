using Avalonia.Media;

namespace IconPark.Icons;

public class MedicineChest: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = -1,
            FillIndex = 45,
            InheritStrokeWidth = false,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M19 8H29V4H19V8ZM30 9V16H34V9H30ZM18 16V9H14V16H18ZM29 8C29.5523 8 30 8.44772 30 9H34C34 6.23858 31.7614 4 29 4V8ZM19 4C16.2386 4 14 6.23858 14 9H18C18 8.44772 18.4477 8 19 8V4Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M18 29L30 29")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M24 23V35")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
