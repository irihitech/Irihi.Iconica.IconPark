using Avalonia.Media;

namespace IconPark.Icons;

public class Sickbed: IconParkIconBase
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
                "M4 23L40 35")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M29 36L29.0001 31.5L19 28V36H29Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M18 27.5L23 14L41.3744 20.9998C42.8515 21.5625 43.6385 23.1747 43.1737 24.6855L40 35")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
