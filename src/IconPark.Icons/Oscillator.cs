using Avalonia.Media;

namespace IconPark.Icons;

public class Oscillator: IconParkIconBase
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
                "M7 9V24C7 27.3137 9.68629 30 13 30H35C38.3137 30 41 27.3137 41 24V9")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M7 10C7 6.68629 9.68629 4 13 4H35C38.3137 4 41 6.68629 41 10C41 13.3137 38.3137 16 35 16H13C9.68629 16 7 13.3137 7 10Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M19 30V44")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M29 30V44")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
