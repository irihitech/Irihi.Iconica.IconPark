using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Immutable;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.Messaging;
using IconDemo.Messages;
using IconDemo.ViewModels;
using Irihi.Avalonia.Shared.Helpers;
using Ursa.Controls;

namespace IconDemo.Views;

public partial class MainWindow : UrsaWindow
{
    public MainWindow()
    {
        InitializeComponent();
        WeakReferenceMessenger.Default.Register<MainWindow, ColorResourceChangeMessage>(this,
            OnColorResourceChanged);
        WeakReferenceMessenger.Default.Register<MainWindow, SizeResourceChangeMessage>(this, OnSizeResourceChanged);
        WeakReferenceMessenger.Default.Register<MainWindow, StrokeWidthResourceChangeMessage>(this, OnStrokeWidthChanged);
        WeakReferenceMessenger.Default.Register<MainWindow, ModeResourceChangeMessage>(this, OnModeChanged);
        this.GetObservable(ActualThemeVariantProperty).Subscribe(OnActualThemeChanged);
    }

    private void OnModeChanged(MainWindow recipient, ModeResourceChangeMessage message)
    {
        this.Resources["IconMode"] = message.Value;
    }

    private void OnStrokeWidthChanged(MainWindow recipient, StrokeWidthResourceChangeMessage message)
    {
        this.Resources["IconStrokeWidth"] = message.Value;
    }

    private void OnSizeResourceChanged(MainWindow recipient, SizeResourceChangeMessage message)
    {
        this.Resources["IconSize"] = message.Value;
    }

    private void OnColorResourceChanged(MainWindow recipient, ColorResourceChangeMessage message)
    {
        var themeProvider = Resources.ThemeDictionaries[ActualThemeVariant];
        if (themeProvider is ResourceDictionary rd && message.Value is not null)
            rd[message.ResourceKey] = new ImmutableSolidColorBrush(message.Value.Value);
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