using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;
using IconDemo.ViewModels;

namespace IconDemo.Views;

public partial class IconViewer : UserControl
{
    private readonly DispatcherTimer _resizeDebounceTimer = new()
    {
        Interval = TimeSpan.FromMilliseconds(50),
    };

    public IconViewer()
    {
        InitializeComponent();
        IconsContainer.SizeChanged += OnContainerSizeChanged;
        _resizeDebounceTimer.Tick += (_, _) =>
        {
            _resizeDebounceTimer.Stop();
            ColumnCount = Math.Max(1, (int)(IconsContainer.Bounds.Width / 200));
            Dispatcher.UIThread.Post(() => NavAnchor?.InvalidatePositions());
        };
    }

    private void OnContainerSizeChanged(object? sender, SizeChangedEventArgs e)
    {
        _resizeDebounceTimer.Stop();
        _resizeDebounceTimer.Start();
    }

    public static readonly StyledProperty<int> ColumnCountProperty = AvaloniaProperty.Register<IconViewer, int>(
        nameof(ColumnCount));

    public int ColumnCount
    {
        get => GetValue(ColumnCountProperty);
        set => SetValue(ColumnCountProperty, value);
    }

    protected override void OnLoaded(RoutedEventArgs e)
    {
        base.OnLoaded(e);
        if (this.DataContext is IconViewerViewModel vm)
        {
            vm.OnLoad();
        }
    }
}