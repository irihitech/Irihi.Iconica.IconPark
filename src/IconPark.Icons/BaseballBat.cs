using Avalonia.Media;

namespace IconPark.Icons;

public class BaseballBat: IconParkIconBase
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
                "M16.502 9.43095C16.502 9.43095 26.4998 22 37.4998 37.5C21.4998 26 9.43102 16.5021 9.43102 16.5021C9.43102 16.5021 3.11056 10.8894 6.99983 7.00032C10.8891 3.11124 16.502 9.43095 16.502 9.43095Z")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
