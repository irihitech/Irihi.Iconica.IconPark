using Avalonia.Media;

namespace IconPark.Icons;

public class SplitBranch: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = -1,
            FillIndex = 45,
            InheritStrokeWidth = false,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M44 44V4H24V17L33 26V44H44Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = -1,
            FillIndex = 45,
            InheritStrokeWidth = false,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M4 4V44H25V30L16 21V4H4Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M44 44V4H24V17L33 26V44H44Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M4 4V44H25V30L16 21V4H4Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
