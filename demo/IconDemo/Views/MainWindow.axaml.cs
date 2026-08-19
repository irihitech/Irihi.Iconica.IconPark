using Avalonia;
using Avalonia.Interactivity;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.Messaging;
using Irihi.Avalonia.Shared.Helpers;
using Ursa.Controls;

namespace IconDemo.Views;

public partial class MainWindow : UrsaWindow
{
    public MainWindow()
    {
        InitializeComponent();
        this.GetObservable(ActualThemeVariantProperty).Subscribe(OnActualThemeChanged);
    }

    protected override void OnLoaded(RoutedEventArgs e)
    {
        base.OnLoaded(e);
        WeakReferenceMessenger.Default.Send(ActualThemeVariant);
    }

    private static void OnActualThemeChanged(ThemeVariant themeVariant)
    {
        WeakReferenceMessenger.Default.Send(themeVariant);
    }
}
