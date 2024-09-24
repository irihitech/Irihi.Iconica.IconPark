using Avalonia.Media;

namespace IconPark.Icons;

public class ElectricWave: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M12 25H15L19 14L22 36L27 23L31 29L34 25H37")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
