using Avalonia.Media;

namespace Irihi.Iconica.TDesign.Icons;

public class CheckRectangle : TDesignIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            FillIndex = 1,
            StrokeIndex = 0,
            Data = StreamGeometry.Parse(
                "M3 3H21V21H3V3Z"),
        },
        new PathDrawingElement()
        {
            StrokeIndex = 2,
            Data = StreamGeometry.Parse(
                "M16.5 9L10.5 15L7.5 12"),
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
