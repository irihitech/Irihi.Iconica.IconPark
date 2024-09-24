using Avalonia.Media;

namespace IconPark.Icons;

public class IdCardH: IconParkIconBase
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
                "M17 25C19.2091 25 21 23.2091 21 21C21 18.7909 19.2091 17 17 17C14.7909 17 13 18.7909 13 21C13 23.2091 14.7909 25 17 25Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M23 31C23 27.6863 20.3137 25 17 25C13.6863 25 11 27.6863 11 31")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M28 20H36")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M30 28H36")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
