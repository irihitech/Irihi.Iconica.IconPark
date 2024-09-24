using Avalonia.Media;

namespace IconPark.Icons;

public class Headwear: IconParkIconBase
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
                "M12.4167 43C10.095 40.0682 8 35.7788 8 31C8 22.1634 15.1634 15 24 15C32.8366 15 40 22.1634 40 31C40 35.7788 37.905 40.0682 35.5833 43")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M34 13.5L43 5L40 17L35 18L34 13.5Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M14 13.5L5 5L8 17L13 18L14 13.5Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
