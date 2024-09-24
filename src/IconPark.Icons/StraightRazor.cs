using Avalonia.Media;

namespace IconPark.Icons;

public class StraightRazor: IconParkIconBase
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
                "M44 40L40 36")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M8 4L26.3848 22.3848L22.1421 26.6274C22.1421 26.6274 12.2426 16.7279 9.41419 13.8995C6.58577 11.071 6.58575 9.65682 6.58577 8.24262C6.58579 6.82843 8 4 8 4Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M8 4L26 22L35 31")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
