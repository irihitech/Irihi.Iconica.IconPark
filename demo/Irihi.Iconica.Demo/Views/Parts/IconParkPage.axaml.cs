using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Immutable;
using CommunityToolkit.Mvvm.Messaging;
using Irihi.Iconica.Demo.Messages;

namespace Irihi.Iconica.Demo.Views;

public partial class IconParkPage : UserControl
{
    public IconParkPage()
    {
        InitializeComponent();
        WeakReferenceMessenger.Default.Register<IconParkPage, ColorResourceChangeMessage, string>(this,
            MessengerChannels.IconPark, OnColorResourceChanged);
        WeakReferenceMessenger.Default.Register<IconParkPage, SizeResourceChangeMessage, string>(this,
            MessengerChannels.IconPark, OnSizeResourceChanged);
        WeakReferenceMessenger.Default.Register<IconParkPage, StrokeWidthResourceChangeMessage, string>(this,
            MessengerChannels.IconPark, OnStrokeWidthChanged);
        WeakReferenceMessenger.Default.Register<IconParkPage, ModeResourceChangeMessage, string>(this,
            MessengerChannels.IconPark, OnModeChanged);
    }

    private void OnModeChanged(IconParkPage recipient, ModeResourceChangeMessage message)
    {
        Resources["IconMode"] = message.Value;
    }

    private void OnStrokeWidthChanged(IconParkPage recipient, StrokeWidthResourceChangeMessage message)
    {
        Resources["IconStrokeWidth"] = message.Value;
    }

    private void OnSizeResourceChanged(IconParkPage recipient, SizeResourceChangeMessage message)
    {
        Resources["IconSize"] = message.Value;
    }

    private void OnColorResourceChanged(IconParkPage recipient, ColorResourceChangeMessage message)
    {
        // 仅在页面处于可视树中时 ActualThemeVariant 才是准确的；
        // 非激活页面写入的旧主题条目会在页面重新加载（OnLoaded）后由主题消息校正。
        if (message.Value is not null &&
            Resources.ThemeDictionaries[ActualThemeVariant] is ResourceDictionary rd)
        {
            rd[message.ResourceKey] = new ImmutableSolidColorBrush(message.Value.Value);
        }
    }

    protected override void OnLoaded(RoutedEventArgs e)
    {
        base.OnLoaded(e);
        // 触发设置面板按当前主题重发颜色，校正本页资源。
        WeakReferenceMessenger.Default.Send(ActualThemeVariant);
    }
}
