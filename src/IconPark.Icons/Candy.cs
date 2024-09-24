using Avalonia.Media;

namespace IconPark.Icons;

public class Candy: IconParkIconBase
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
                "M24 28C21.7909 28 20 26.2091 20 24")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M16.6875 16.8125L3.90824 14.9668L14.8418 4.03324L16.6875 16.8125Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M31.3125 31.3125L44.0918 33.1582L33.1582 44.0918L31.3125 31.3125Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
