using Avalonia.Media;

namespace IconPark.Icons;

public class Tabletennis: IconParkIconBase
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
                "M31.4502 16.96C34.2116 16.96 36.4502 14.7214 36.4502 11.96C36.4502 9.19854 34.2116 6.95996 31.4502 6.95996C28.6888 6.95996 26.4502 9.19854 26.4502 11.96C26.4502 14.7214 28.6888 16.96 31.4502 16.96Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M36 34L34 23L23 28L10 25")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M4 41.0298H44")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M34 23L44 29L29 34")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
