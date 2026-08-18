using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Documents;
using Avalonia.Media;
using Irihi.Iconica.Core;

namespace Irihi.Iconica.TDesign.Icons;

public abstract class TDesignIconBase : Control
{
    public static readonly StyledProperty<IBrush?> Stroke1Property =
        TextElement.ForegroundProperty.AddOwner<TDesignIconBase>();

    public static readonly StyledProperty<IBrush?> Fill1Property =
        AvaloniaProperty.Register<TDesignIconBase, IBrush?>(
            nameof(Fill1), new SolidColorBrush(Color.Parse("#BBD3FB")));

    public static readonly StyledProperty<IBrush?> Stroke2Property =
        AvaloniaProperty.Register<TDesignIconBase, IBrush?>(
            nameof(Stroke2), new SolidColorBrush(Color.Parse("#0052D9")));

    public static readonly StyledProperty<IBrush?> Fill2Property =
        AvaloniaProperty.Register<TDesignIconBase, IBrush?>(
            nameof(Fill2), new SolidColorBrush(Color.Parse("#F78D94")));

    public static readonly StyledProperty<double> StrokeWidthProperty =
        AvaloniaProperty.Register<TDesignIconBase, double>(
            nameof(StrokeWidth), 2);

    public static readonly StyledProperty<PenLineCap> LineCapProperty =
        AvaloniaProperty.Register<TDesignIconBase, PenLineCap>(
            nameof(LineCap), PenLineCap.Round);

    public static readonly StyledProperty<PenLineJoin> LineJoinProperty =
        AvaloniaProperty.Register<TDesignIconBase, PenLineJoin>(
            nameof(LineJoin), PenLineJoin.Round);

    public static readonly StyledProperty<IconMode> ModeProperty =
        AvaloniaProperty.Register<TDesignIconBase, IconMode>(
            nameof(Mode));

    public static readonly StyledProperty<IBrush?> BackgroundProperty =
        AvaloniaProperty.Register<TDesignIconBase, IBrush?>(
            nameof(Background));

    public static readonly StyledProperty<IBrush?> FallbackBrushProperty =
        AvaloniaProperty.Register<TDesignIconBase, IBrush?>(
            nameof(FallbackBrush), Brushes.White);

    // 0: Stroke1, 1: Fill1, 2: Stroke2, 3: Fill2, 4: WhiteFallback, 5: NullFallback
    private readonly IBrush?[] _brushes = new IBrush[6];
    private readonly Pen?[] _pens = new Pen?[6];


    static TDesignIconBase()
    {
        WidthProperty.OverrideDefaultValue<TDesignIconBase>(24);
        HeightProperty.OverrideDefaultValue<TDesignIconBase>(24);
        Stroke1Property.Changed.AddClassHandler<TDesignIconBase, IBrush?>((icon, e) => icon.InvalidateBrushes(e, 0));
        Fill1Property.Changed.AddClassHandler<TDesignIconBase, IBrush?>((icon, e) => icon.InvalidateBrushes(e, 1));
        Stroke2Property.Changed.AddClassHandler<TDesignIconBase, IBrush?>((icon, e) => icon.InvalidateBrushes(e, 2));
        Fill2Property.Changed.AddClassHandler<TDesignIconBase, IBrush?>((icon, e) => icon.InvalidateBrushes(e, 3));
        FallbackBrushProperty.Changed.AddClassHandler<TDesignIconBase, IBrush?>((icon, e) => icon.InvalidateBrushes(e, 4));
        StrokeWidthProperty.Changed.AddClassHandler<TDesignIconBase, double>((icon, e) => icon.InvalidateStrokeWidth(e));
        LineCapProperty.Changed.AddClassHandler<TDesignIconBase, PenLineCap>((icon, e) => icon.InvalidateLineCap(e));
        LineJoinProperty.Changed.AddClassHandler<TDesignIconBase, PenLineJoin>((icon, e) => icon.InvalidateLineJoin(e));
        AffectsRender<TDesignIconBase>(ModeProperty);
    }

    protected TDesignIconBase()
    {
        _brushes[4] = Brushes.White;
        _pens[4] = new Pen(Brushes.White);
    }

    public IBrush? Stroke1
    {
        get => GetValue(Stroke1Property);
        set => SetValue(Stroke1Property, value);
    }

    public IBrush? Fill1
    {
        get => GetValue(Fill1Property);
        set => SetValue(Fill1Property, value);
    }

    public IBrush? Stroke2
    {
        get => GetValue(Stroke2Property);
        set => SetValue(Stroke2Property, value);
    }

    public IBrush? Fill2
    {
        get => GetValue(Fill2Property);
        set => SetValue(Fill2Property, value);
    }

    public IBrush? FallbackBrush
    {
        get => GetValue(FallbackBrushProperty);
        set => SetValue(FallbackBrushProperty, value);
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
        _brushes[0] = Stroke1;
        _brushes[1] = Fill1;
        _brushes[2] = Stroke2;
        _brushes[3] = Fill2;
        _brushes[4] = FallbackBrush;
        _pens[0] = new Pen(Stroke1, StrokeWidth, lineCap: LineCap, lineJoin: LineJoin);
        _pens[1] = new Pen(Fill1, StrokeWidth, lineCap: LineCap, lineJoin: LineJoin);
        _pens[2] = new Pen(Stroke2, StrokeWidth, lineCap: LineCap, lineJoin: LineJoin);
        _pens[3] = new Pen(Fill2, StrokeWidth, lineCap: LineCap, lineJoin: LineJoin);
        _pens[4] = new Pen(FallbackBrush, StrokeWidth, lineCap: LineCap, lineJoin: LineJoin);
    }

    private void InvalidateBrushes(AvaloniaPropertyChangedEventArgs<IBrush?> args, int index)
    {
        _brushes[index] = args.NewValue.Value;
        InvalidatePens(index);
    }

    private void InvalidatePens(int? index = null)
    {
        if (index is null)
            for (var i = 0; i < 6; i++)
                _pens[i] = new Pen(_brushes[i], StrokeWidth, lineCap: LineCap, lineJoin: LineJoin);
        else
            _pens[index.Value] = new Pen(_brushes[index.Value], StrokeWidth, lineCap: LineCap, lineJoin: LineJoin);
        InvalidateVisual();
    }

    private void InvalidateStrokeWidth(AvaloniaPropertyChangedEventArgs<double> args)
    {
        foreach (var pen in _pens)
        {
            pen?.Thickness = args.NewValue.Value;
        }

        InvalidateVisual();
    }

    private void InvalidateLineCap(AvaloniaPropertyChangedEventArgs<PenLineCap> args)
    {
        foreach (var pen in _pens)
        {
            pen?.LineCap = args.NewValue.Value;
        }

        InvalidateVisual();
    }

    private void InvalidateLineJoin(AvaloniaPropertyChangedEventArgs<PenLineJoin> args)
    {
        foreach (var pen in _pens)
        {
            pen?.LineJoin = args.NewValue.Value;
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
            case IconMode.OutlineSingle:
                result = index switch
                {
                    0 => 0,
                    2 => 0,
                    _ => 5
                };
                break;
            case IconMode.OutlineDouble:
                result = index switch
                {
                    0 => 0,
                    2 => 2,
                    _ => 5
                };
                break;
            case IconMode.FilledDouble:
                result = index switch
                {
                    0 => 0,
                    1 => 1,
                    2 => 0,
                    3 => 1,
                    _ => 5
                };
                break;
            case IconMode.FilledMultiple:
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
        context.FillRectangle(Background ?? Brushes.Transparent, Bounds);
        if (DrawingData == null) return;
        var mode = Mode;
        Matrix.CreateRotation(1);
        var scale = new Vector(Bounds.Width / 24.0, Bounds.Height / 24.0);
        using (context.PushTransform(Matrix.CreateScale(scale)))
        {
            foreach (var element in DrawingData)
            {
                if (element is PathDrawingElement pde)
                {
                    context.DrawPathElement(pde, GetBrush(mode, element.FillIndex),
                        GetPen(mode, element.StrokeIndex));
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
                    context.DrawRectElement(rde, GetBrush(mode, element.FillIndex),
                        GetPen(mode, element.StrokeIndex));
                }
            }
        }
    }
}