using Avalonia.Media;

namespace Irihi.Iconica.TDesign.Icons;

public class App : TDesignIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            FillIndex = 1,
            StrokeIndex = 0,
            Data = StreamGeometry.Parse(
                "M3 3H10V10H3V3ZM14 14H21V21H14V14ZM3 14H10V21H3V14Z"),
        },
        new PathDrawingElement()
        {
            FillIndex = 3,
            StrokeIndex = 2,
            Data = StreamGeometry.Parse(
                "M21.5 6.5C21.5 8.70914 19.7091 10.5 17.5 10.5C15.2909 10.5 13.5 8.70914 13.5 6.5C13.5 4.29086 15.2909 2.5 17.5 2.5C19.7091 2.5 21.5 4.29086 21.5 6.5Z"),
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
