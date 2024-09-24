using System.Collections.Concurrent;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace IconPark.Icons;

public abstract class IconParkIconBase : Control
{
   
    public static readonly StyledProperty<IBrush?> OuterStrokeProperty =
        AvaloniaProperty.Register<IconParkIconBase, IBrush?>(
            nameof(OuterStroke));

    public static readonly StyledProperty<IBrush?> OuterFillProperty =
        AvaloniaProperty.Register<IconParkIconBase, IBrush?>(
            nameof(OuterFill));

    public static readonly StyledProperty<IBrush?> InnerStrokeProperty =
        AvaloniaProperty.Register<IconParkIconBase, IBrush?>(
            nameof(InnerStroke));

    public static readonly StyledProperty<IBrush?> InnerFillProperty =
        AvaloniaProperty.Register<IconParkIconBase, IBrush?>(
            nameof(InnerFill));

    public static readonly StyledProperty<double> StrokeWidthProperty =
        AvaloniaProperty.Register<IconParkIconBase, double>(
            nameof(StrokeWidth));

    public static readonly StyledProperty<PenLineCap> LineCapProperty =
        AvaloniaProperty.Register<IconParkIconBase, PenLineCap>(
            nameof(LineCap));

    public static readonly StyledProperty<PenLineJoin> LineJoinProperty =
        AvaloniaProperty.Register<IconParkIconBase, PenLineJoin>(
            nameof(LineJoin));

    public static readonly StyledProperty<IconMode> ModeProperty =
        AvaloniaProperty.Register<IconParkIconBase, IconMode>(
            nameof(Mode));

    public static readonly StyledProperty<IBrush?> BackgroundProperty =
        AvaloniaProperty.Register<IconParkIconBase, IBrush?>(
            nameof(Background));


    static IconParkIconBase()
    {
    }

    public IBrush? OuterStroke
    {
        get => GetValue(OuterStrokeProperty);
        set => SetValue(OuterStrokeProperty, value);
    }

    public IBrush? OuterFill
    {
        get => GetValue(OuterFillProperty);
        set => SetValue(OuterFillProperty, value);
    }

    public IBrush? InnerStroke
    {
        get => GetValue(InnerStrokeProperty);
        set => SetValue(InnerStrokeProperty, value);
    }

    public IBrush? InnerFill
    {
        get => GetValue(InnerFillProperty);
        set => SetValue(InnerFillProperty, value);
    }

    public double StrokeWidth
    {
        get => GetValue(StrokeWidthProperty);
        set => SetValue(StrokeWidthProperty, value);
    }

    public PenLineCap LineCap
    {
        get => GetValue(LineCapProperty);
        set => SetValue(LineCapProperty, value);
    }

    public PenLineJoin LineJoin
    {
        get => GetValue(LineJoinProperty);
        set => SetValue(LineJoinProperty, value);
    }

    public IconMode Mode
    {
        get => GetValue(ModeProperty);
        set => SetValue(ModeProperty, value);
    }

    public IBrush? Background
    {
        get => GetValue(BackgroundProperty);
        set => SetValue(BackgroundProperty, value);
    }
    
    protected abstract DrawingElement[]? DrawingData { get; }

    public override void Render(DrawingContext context)
    {
        base.Render(context);
        if (DrawingData == null)
        {
            return;
        }

        foreach (var element in DrawingData)
        {
            if (element is PathDrawingElement pde)
            {
                context.DrawPathElement(pde, null, null);
            }
        }
    }
}