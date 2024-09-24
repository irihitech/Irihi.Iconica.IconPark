using Avalonia.Media;

namespace IconPark.Icons;

public class Makeups: IconParkIconBase
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
                "M44 24C44 35.0457 35.0457 44 24 44C12.9543 44 4 35.0457 4 24C4 12.9543 12.9543 4 24 4")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M37.6098 9.47214L37.8652 10.2582H38.6917L38.023 10.744L38.2784 11.5301L37.6098 11.0443L36.9411 11.5301L37.1965 10.744L36.5278 10.2582H37.3543L37.6098 9.47214Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M16 31C16 31 18 35 24 35C30 35 32 31 32 31")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
