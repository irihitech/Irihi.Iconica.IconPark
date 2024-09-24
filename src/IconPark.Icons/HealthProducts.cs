using Avalonia.Media;

namespace IconPark.Icons;

public class HealthProducts: IconParkIconBase
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
                "M33 12H15L10 17.8428V38.0919L15 44H33L38 38.0919V17.8428L33 12Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M19 20H23.5455H29")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M33 12V7C33 5.34315 31.6569 4 30 4H18C16.3431 4 15 5.34315 15 7V12")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
