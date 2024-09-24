using Avalonia.Media;

namespace IconPark.Icons;

public class Panda: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M40.9995 20.999C44.1237 17.8748 44.4376 12.7804 41.3134 9.65616C38.1892 6.53196 32.124 6.87507 28.9998 9.99927")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M7 20.9995C3.87581 17.8753 3.53224 12.7807 6.65644 9.65655C9.78063 6.53236 15.8758 6.87532 19 9.99951")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 2,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M20 35C20.5 36.2935 22.2 38.2769 25 35.8623C27.8 38.2769 29.5 36.2935 30 35")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
