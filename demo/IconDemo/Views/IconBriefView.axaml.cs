using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Immutable;
using CommunityToolkit.Mvvm.Messaging;
using IconDemo.Messages;
using IconDemo.Models;

namespace IconDemo.Views;

public partial class IconBriefView : UserControl
{
    public IconBriefView()
    {
        InitializeComponent();
    }

    private void InputElement_OnPointerPressed(object? sender, PointerPressedEventArgs e)
    {
        if (DataContext is IconInfo info)
        {
            WeakReferenceMessenger.Default.Send(info);
        }
    }
}