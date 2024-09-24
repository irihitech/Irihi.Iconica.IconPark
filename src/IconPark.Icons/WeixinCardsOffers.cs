using Avalonia.Media;

namespace IconPark.Icons;

public class WeixinCardsOffers: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            FillIndex = 1,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M6 12L42 16V40L6 36V12Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M38 15.5554V8L6.00049 11.9999")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
