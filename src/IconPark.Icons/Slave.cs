using Avalonia.Media;

namespace IconPark.Icons;

public class Slave: IconParkIconBase
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
                "M38 38V30.5M10 38V6C10 4.89543 10.8954 4 12 4H36C37.1046 4 38 4.89543 38 6V7")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M25 13H24C20.6863 13 18 15.6863 18 19V19C18 22.3137 20.6863 25 24 25H25")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M33 13H34C37.3137 13 40 15.6863 40 19V19C40 22.3137 37.3137 25 34 25H33")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M25 19H33")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M10 38C10 34.6863 12.6863 32 16 32H32C35.3137 32 38 34.6863 38 38C38 41.3137 35.3137 44 32 44H16C12.6863 44 10 41.3137 10 38Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
