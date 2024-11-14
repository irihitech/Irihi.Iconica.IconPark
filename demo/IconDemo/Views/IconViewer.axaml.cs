using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using IconDemo.ViewModels;

namespace IconDemo.Views;

public partial class IconViewer : UserControl
{
    public IconViewer()
    {
        InitializeComponent();
        this.DataContext = new IconViewerViewModel();
        IconsContainer.SizeChanged += OnContainerSizeChanged;
    }
    
    private void OnContainerSizeChanged(object? sender, SizeChangedEventArgs e)
    {
        ColumnCount = (int) (e.NewSize.Width / 300);
    }

    public static readonly StyledProperty<int> ColumnCountProperty = AvaloniaProperty.Register<MainWindow, int>(
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