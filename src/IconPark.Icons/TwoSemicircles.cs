using Avalonia.Media;

namespace IconPark.Icons;

public class TwoSemicircles: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M44 25C44 13.9543 35.0457 5 24 5C12.9543 5 4 13.9543 4 25H44Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M14 32C14 37.5228 18.4772 42 24 42C29.5228 42 34 37.5228 34 32H14Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
