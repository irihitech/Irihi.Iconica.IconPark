using Avalonia.Media;

namespace IconPark.Icons;

public class RemoteControlOne: IconParkIconBase
{
    private static readonly DrawingElement[]? StaticDrawingData =
    [
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = false,
            InheritStrokeJoin = false,
            Data = StreamGeometry.Parse(
                "M11 5.44578C11 4.6473 11.6473 4 12.4458 4H35.5542C36.3527 4 37 4.6473 37 5.44578V31C37 38.1797 31.1797 44 24 44V44C16.8203 44 11 38.1797 11 31V5.44578Z")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M17 16H20")
        },
        new PathDrawingElement()
        {
            StrokeIndex = 0,
            InheritStrokeWidth = true,
            InheritStrokeCap = true,
            InheritStrokeJoin = true,
            Data = StreamGeometry.Parse(
                "M28 16H31")
        },
    ];

    protected override DrawingElement[]? DrawingData => StaticDrawingData;
}
