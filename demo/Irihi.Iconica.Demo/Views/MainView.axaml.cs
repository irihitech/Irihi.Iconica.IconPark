using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.Messaging;
using Irihi.Iconica.Demo.ViewModels;
using Irihi.Avalonia.Shared.Helpers;

namespace Irihi.Iconica.Demo.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        if (Application.Current is { } app)
        {
            app.GetObservable(Application.ActualThemeVariantProperty).Subscribe(OnActualThemeChanged);
        }
    }

    protected override void OnLoaded(RoutedEventArgs e)
    {
        base.OnLoaded(e);
        if (Application.Current is { } app)
        {
            WeakReferenceMessenger.Default.Send(app.ActualThemeVariant);
        }
    }

    private static void OnActualThemeChanged(ThemeVariant themeVariant)
    {
        WeakReferenceMessenger.Default.Send(themeVariant);
    }
}
