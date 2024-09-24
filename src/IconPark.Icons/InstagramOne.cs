using Avalonia.Media;

namespace IconPark.Icons;

public class InstagramOne: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 45,
            FillIndex = 45,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M21 27.5V43H28V29C28 26.5 29.5 24.5 32 24.5C34.5 24.5 36 27 36 29V43H43V27.5C43 24.5 39.5 18 32 18C24.5 18 21 24.5 21 27.5Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
