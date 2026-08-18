using Avalonia.Media;

namespace Irihi.Iconica.TDesign.Icons;

public class Setting : TDesignIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            FillIndex = 1,
            StrokeIndex = 0,
            Data = StreamGeometry.Parse(
                "M12.0001 2L20.6604 7V17L12.0001 22L3.33984 17V7L12.0001 2Z"),
        },
        new PathDrawingElement()
        {
            FillIndex = 3,
            StrokeIndex = 2,
            Data = StreamGeometry.Parse(
                "M16 12C16 14.2091 14.2091 16 12 16C9.79086 16 8 14.2091 8 12C8 9.79086 9.79086 8 12 8C14.2091 8 16 9.79086 16 12Z"),
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
