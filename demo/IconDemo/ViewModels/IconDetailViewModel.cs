using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using IconDemo.Models;

namespace IconDemo.ViewModels;

public partial class IconDetailViewModel : ObservableObject
{
    [ObservableProperty] private IconInfo? _iconInfo;

    public IconDetailViewModel()
    {
        WeakReferenceMessenger.Default.Register<IconDetailViewModel, IconInfo>(this, OnIconChanged);
    }

    private void OnIconChanged(IconDetailViewModel recipient, IconInfo message)
    {
        IconInfo = message;
    }
}