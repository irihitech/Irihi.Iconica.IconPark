using Avalonia.Media;

namespace IconPark.Icons;

public class RoadCone: IconParkIconBase
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
                "M27 6H21L19.75 10.5L18.5 15L16 24L13.5 33L12.25 37.5L11 42H37L35.5 36.6L32 24L29.5 15L28.25 10.5L27 6Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M37 42L35.5 36.6L32 24L29.5 15L28.25 10.5L27 6H21L19.75 10.5L18.5 15L16 24L13.5 33L12.25 37.5L11 42M37 42H11H37ZM37 42H6H11H37ZM37 42H42H37Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M13.5 33H34.5")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M32 24H16")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M29.5 15H18.5")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M28.25 10.5L35.5 36.6")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M12.25 37.5L19.75 10.5")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
