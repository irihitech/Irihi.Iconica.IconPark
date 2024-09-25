using Avalonia;
using Avalonia.Media;

namespace IconPark.Icons;

public abstract class IconParkIconBase : Avalonia.Controls.Control
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

    private IBrush? GetBrush(int index)
    {
        if (Mode == IconMode.Line)
            return index switch
            {
                0 => OuterStroke,
                2 => OuterStroke,
                _ => null
            };
        if (Mode == IconMode.Fill)
            return index switch
            {
                0 => OuterStroke,
                1 => OuterStroke,
                2 => Brushes.White,
                3 => Brushes.White,
                _ => null
            };

        if (Mode == IconMode.TwoTone)
            return index switch
            {
                0 => OuterStroke,
                1 => OuterFill,
                2 => OuterStroke,
                3 => OuterFill,
                _ => null
            };
        return index switch
        {
            0 => OuterStroke,
            1 => OuterFill,
            2 => InnerStroke,
            3 => InnerFill,
            _ => null
        };
    }

    public override void Render(DrawingContext context)
    {
        base.Render(context);
        if (DrawingData == null) return;
        Matrix.CreateRotation(1);
        var scale = new Vector(Bounds.Width / 48.0, Bounds.Height / 48.0);
        using (context.PushTransform(Matrix.CreateScale(scale)))
        {
            foreach (var element in DrawingData)
            {
                if (element is PathDrawingElement pde)
                    context.DrawPathElement(pde, GetBrush(element.FillIndex),
                        new Pen(GetBrush(element.StrokeIndex), 2, lineCap: LineCap, lineJoin: LineJoin), scale);
                else if (element is EllipseDrawingElement ede)
                    context.DrawEllipseElement(ede, GetBrush(element.FillIndex),
                        new Pen(GetBrush(element.StrokeIndex), 2, lineCap: LineCap, lineJoin: LineJoin), scale);
                else if (element is LineDrawingElement lde)
                    context.DrawLineElement(lde,
                        new Pen(GetBrush(element.StrokeIndex), 2, lineCap: LineCap, lineJoin: LineJoin), scale);
                else if (element is RectDrawingElement rde)
                    context.DrawRectElement(rde, GetBrush(element.FillIndex),
                        new Pen(GetBrush(element.StrokeIndex), 2, lineCap: LineCap, lineJoin: LineJoin), scale);
            }
        }
    }
}