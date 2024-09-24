using Avalonia.Media;

namespace IconPark.Icons;

public class Telescope: IconParkIconBase
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
                "M12 43C15.3137 43 18 40.3137 18 37C18 33.6863 15.3137 31 12 31C8.68629 31 6 33.6863 6 37C6 40.3137 8.68629 43 12 43Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M36 43C39.3137 43 42 40.3137 42 37C42 33.6863 39.3137 31 36 31C32.6863 31 30 33.6863 30 37C30 40.3137 32.6863 43 36 43Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M30 21C30 17.6863 27.3137 15 24 15C20.6863 15 18 17.6863 18 21")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M30 31C30 27.6863 27.3137 25 24 25C20.6863 25 18 27.6863 18 31")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
