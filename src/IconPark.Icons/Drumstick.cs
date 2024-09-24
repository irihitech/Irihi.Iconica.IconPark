using Avalonia.Media;

namespace IconPark.Icons;

public class Drumstick: IconParkIconBase
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
                "M14.1508 33.8198L12.7366 43.7193L4.25135 35.234L14.1508 33.8198Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M24.0498 6.9502L14.1503 16.8497C9.46402 21.536 9.46402 29.134 14.1503 33.8203V33.8203C18.8366 38.5065 26.4346 38.5065 31.1209 33.8203L41.0204 23.9208")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
