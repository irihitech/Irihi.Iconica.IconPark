using Avalonia.Media;

namespace IconPark.Icons;

public class Microwaves: IconParkIconBase
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
                "M20 19H24")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M13 25L35 25")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M12 34L12 38")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M20 34L20 38")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M28 34L28 38")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M36 34L36 38")
        },
        new PathDrawingElement()
        {
            StrokeIndex = -1,
            FillIndex = 0,
            InheritStrokeWidth = false,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M15 19C15 20.1046 14.1046 21 13 21C11.8954 21 11 20.1046 11 19C11 17.8954 11.8954 17 13 17C14.1046 17 15 17.8954 15 19Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
