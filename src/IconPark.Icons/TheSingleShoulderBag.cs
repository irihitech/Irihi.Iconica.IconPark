using Avalonia.Media;

namespace IconPark.Icons;

public class TheSingleShoulderBag: IconParkIconBase
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
                "M28 27C28 18.1813 26.7806 4 24 4C20.5714 4 20 18.1813 20 27")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            FillIndex = 1,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M15 27H33L27.7059 36H19.7647L15 27Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
