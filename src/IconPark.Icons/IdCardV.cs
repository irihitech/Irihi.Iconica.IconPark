using Avalonia.Media;

namespace IconPark.Icons;

public class IdCardV: IconParkIconBase
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
                "M24 19C26.2091 19 28 17.2091 28 15C28 12.7909 26.2091 11 24 11C21.7909 11 20 12.7909 20 15C20 17.2091 21.7909 19 24 19Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M30 25C30 21.6863 27.3137 19 24 19C20.6863 19 18 21.6863 18 25")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M18 31H30")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M18 37H25")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
