using Avalonia.Media;

namespace IconPark.Icons;

public class RoundDistortion: IconParkIconBase
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
                "M24 44C18.4772 44 14 39.5228 14 34C14 28.4772 18.4772 24 24 24C29.5228 24 34 19.5228 34 14C34 8.47715 29.5228 4 24 4")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M44 24C44 29.5228 39.5228 34 34 34C28.4772 34 24 29.5228 24 24C24 18.4772 19.5228 14 14 14C8.47715 14 4 18.4772 4 24")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
