using Avalonia.Media;

namespace IconPark.Icons;

public class ShoulderBag: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            FillIndex = 1,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M4.68209 23.5639C4.32813 21.7145 5.74562 20 7.62861 20H40.3714C42.2544 20 43.6719 21.7145 43.3179 23.5639L40.2557 39.5639C39.9851 40.9777 38.7486 42 37.3092 42H10.6908C9.25141 42 8.01487 40.9777 7.74429 39.5639L4.68209 23.5639Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M24 6L15 20H33L24 6Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
