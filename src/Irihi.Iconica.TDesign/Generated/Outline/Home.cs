using Avalonia.Media;

namespace Irihi.Iconica.TDesign.Icons;

public class Home : TDesignIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            FillIndex = 1,
            StrokeIndex = 0,
            Data = StreamGeometry.Parse(
                "M3 10L12 2.5L21 10V21H3V10Z"),
        },
        new PathDrawingElement()
        {
            FillIndex = 3,
            StrokeIndex = 2,
            Data = StreamGeometry.Parse(
                "M9 14H15V21H9V14Z"),
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
