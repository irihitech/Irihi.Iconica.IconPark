using Avalonia.Controls;
using Avalonia.Input;
using CommunityToolkit.Mvvm.Messaging;
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