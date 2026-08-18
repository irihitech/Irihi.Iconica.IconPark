using Avalonia.Media;

namespace Irihi.Iconica.TDesign.Icons;

public class MenuApplication : TDesignIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            Data = StreamGeometry.Parse(
                "M4 4H5V5H4V4ZM11.5 4H12.5V5H11.5V4ZM19 4H20V5H19V4ZM19 11.5H20V12.5H19V11.5ZM19 19H20V20H19V19ZM11.5 11.5H12.5V12.5H11.5V11.5ZM11.5 19H12.5V20H11.5V19ZM4 11.5H5V12.5H4V11.5ZM4 19H5V20H4V19Z"),
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
