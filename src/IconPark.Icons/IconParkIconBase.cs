using Avalonia;
using Avalonia.Media;

namespace IconPark.Icons;

public abstract class IconParkIconBase : Avalonia.Controls.Control
{
    public static readonly StyledProperty<IBrush?> OuterStrokeProperty =
        AvaloniaProperty.Register<IconParkIconBase, IBrush?>(
            nameof(OuterStroke), new SolidColorBrush(Color.Parse("#333")));

    public static readonly StyledProperty<IBrush?> OuterFillProperty =
        AvaloniaProperty.Register<IconParkIconBase, IBrush?>(
            nameof(OuterFill), new SolidColorBrush(Color.Parse("#2F88FF")));

    public static readonly StyledProperty<IBrush?> InnerStrokeProperty =
        AvaloniaProperty.Register<IconParkIconBase, IBrush?>(
            nameof(InnerStroke), Brushes.White);

    public static readonly StyledProperty<IBrush?> InnerFillProperty =
        AvaloniaProperty.Register<IconParkIconBase, IBrush?>(
            nameof(InnerFill), new SolidColorBrush(Color.Parse("#43CCF8")));

    public static readonly StyledProperty<double> StrokeWidthProperty =
        AvaloniaProperty.Register<IconParkIconBase, double>(
            nameof(StrokeWidth), 4);

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

    // 0: OuterStroke, 1: OuterFill, 2: InnerStroke, 3: InnerFill， 4: WhiteFallback, 5: NullFallback
    private readonly IBrush?[] _brushes = new IBrush[6];
    private readonly Pen?[] _pens = new Pen?[6];


    static IconParkIconBase()
    {
        WidthProperty.OverrideDefaultValue<IconParkIconBase>(24);
        HeightProperty.OverrideDefaultValue<IconParkIconBase>(24);
        OuterFillProperty.Changed.AddClassHandler<IconParkIconBase, IBrush?>((icon, e) => icon.InvalidateBrushes(e, 0));
        OuterStrokeProperty.Changed.AddClassHandler<IconParkIconBase, IBrush?>(
            (icon, e) => icon.InvalidateBrushes(e, 1));
        InnerFillProperty.Changed.AddClassHandler<IconParkIconBase, IBrush?>((icon, e) => icon.InvalidateBrushes(e, 2));
        InnerStrokeProperty.Changed.AddClassHandler<IconParkIconBase, IBrush?>(
            (icon, e) => icon.InvalidateBrushes(e, 3));
        StrokeWidthProperty.Changed.AddClassHandler<IconParkIconBase, double>(
            (icon, e) => icon.InvalidateStrokeWidth(e));
        LineCapProperty.Changed.AddClassHandler<IconParkIconBase, PenLineCap>((icon, e) => icon.InvalidateLineCap(e));
        LineJoinProperty.Changed.AddClassHandler<IconParkIconBase, PenLineJoin>((icon, e) =>
            icon.InvalidateLineJoin(e));
        AffectsRender<IconParkIconBase>(ModeProperty);
    }

    protected IconParkIconBase()
    {
        _brushes[4] = Brushes.White;
        _pens[4] = new Pen(Brushes.White);
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

    protected override void OnInitialized()
    {
        base.OnInitialized();
        _brushes[0] = OuterStroke;
        _brushes[1] = OuterFill;
        _brushes[2] = InnerStroke;
        _brushes[3] = InnerFill;
        _pens[0] = new Pen(OuterStroke, StrokeWidth, lineCap: LineCap, lineJoin: LineJoin);
        _pens[1] = new Pen(OuterFill, StrokeWidth, lineCap: LineCap, lineJoin: LineJoin);
        _pens[2] = new Pen(InnerStroke, StrokeWidth, lineCap: LineCap, lineJoin: LineJoin);
        _pens[3] = new Pen(InnerFill, StrokeWidth, lineCap: LineCap, lineJoin: LineJoin);
    }

    private void InvalidateBrushes(AvaloniaPropertyChangedEventArgs<IBrush?> args, int index)
    {
        _brushes[index] = args.NewValue.Value;
        InvalidatePens(index);
    }

    private void InvalidatePens(int? index = null)
    {
        if (index is null)
            for (var i = 0; i < 4; i++)
                _pens[i] = new Pen(_brushes[i], StrokeWidth, lineCap: LineCap, lineJoin: LineJoin);
        else
            _pens[index.Value] = new Pen(_brushes[index.Value], StrokeWidth, lineCap: LineCap, lineJoin: LineJoin);
        InvalidateVisual();
    }

    private void InvalidateStrokeWidth(AvaloniaPropertyChangedEventArgs<double> args)
    {
        foreach (var pen in _pens)
        {
            if (pen is not null)
                pen.Thickness = args.NewValue.Value;
        }

        InvalidateVisual();
    }

    private void InvalidateLineCap(AvaloniaPropertyChangedEventArgs<PenLineCap> args)
    {
        foreach (var pen in _pens)
        {
            if (pen is not null)
                pen.LineCap = args.NewValue.Value;
        }

        InvalidateVisual();
    }

    private void InvalidateLineJoin(AvaloniaPropertyChangedEventArgs<PenLineJoin> args)
    {
        foreach (var pen in _pens)
        {
            if (pen is not null)
                pen.LineJoin = args.NewValue.Value;
        }

        InvalidateVisual();
    }

    private IBrush? GetBrush(IconMode mode, int index)
    {
        var effectiveIndex = GetEffectiveIndex(mode, index);
        return _brushes[effectiveIndex];
    }

    private Pen? GetPen(IconMode mode, int index)
    {
        var effectiveIndex = GetEffectiveIndex(mode, index);
        return _pens[effectiveIndex]!;
    }

    private int GetEffectiveIndex(IconMode mode, int index)
    {
        var result = 0;
        switch (mode)
        {
            case IconMode.Line:
                result = index switch
                {
                    0 => 0,
                    2 => 0,
                    _ => 5
                };
                break;
            case IconMode.Fill:
                result = index switch
                {
                    0 => 0,
                    1 => 0,
                    2 => 4,
                    3 => 4,
                    _ => 5
                };
                break;
            case IconMode.TwoTone:
                result = index switch
                {
                    0 => 0,
                    1 => 1,
                    2 => 0,
                    3 => 1,
                    _ => 5
                };
                break;
            case IconMode.MultiColor:
                result = index switch
                {
                    0 => 0,
                    1 => 1,
                    2 => 2,
                    3 => 3,
                    _ => 5
                };
                break;
        }

        return result;
    }

    public override void Render(DrawingContext context)
    {
        base.Render(context);
        if (DrawingData == null) return;
        var mode = Mode;
        Matrix.CreateRotation(1);
        var scale = new Vector(Bounds.Width / 48.0, Bounds.Height / 48.0);
        using (context.PushTransform(Matrix.CreateScale(scale)))
        {
            foreach (var element in DrawingData)
            {
                if (element is PathDrawingElement pde)
                {
                    context.DrawPathElement(pde, GetBrush(mode, element.FillIndex), GetPen(mode, element.StrokeIndex));
                }
                else if (element is EllipseDrawingElement ede)
                {
                    context.DrawEllipseElement(ede, GetBrush(mode, element.FillIndex),
                        GetPen(mode, element.StrokeIndex));
                }
                else if (element is LineDrawingElement lde)
                {
                    var pen = GetPen(mode, element.StrokeIndex);
                    if (pen is not null) context.DrawLineElement(lde, pen);
                }
                else if (element is RectDrawingElement rde)
                {
                    context.DrawRectElement(rde, GetBrush(mode, element.FillIndex), GetPen(mode, element.StrokeIndex));
                }
            }
        }
    }
}