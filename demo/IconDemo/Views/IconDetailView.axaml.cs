using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Immutable;
using CommunityToolkit.Mvvm.Messaging;
using IconDemo.Messages;
using IconDemo.ViewModels;
using Irihi.Iconica.Icons;

namespace IconDemo.Views;

public partial class IconDetailView : UserControl
{
    public IconDetailView()
    {
        InitializeComponent();
        this.DataContext = new IconDetailViewModel();
    }
    
}