using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Immutable;
using CommunityToolkit.Mvvm.Messaging;
using Irihi.Iconica.Demo.Messages;
using Irihi.Iconica.Demo.Models;
using Irihi.Iconica.Demo.ViewModels;

namespace Irihi.Iconica.Demo.Views;

public partial class TDesignPage : UserControl
{
    public TDesignPage()
    {
        InitializeComponent();
        WeakReferenceMessenger.Default.Register<TDesignPage, ColorResourceChangeMessage, string>(this,
            MessengerChannels.TDesign, OnColorResourceChanged);
        WeakReferenceMessenger.Default.Register<TDesignPage, SizeResourceChangeMessage, string>(this,
            MessengerChannels.TDesign, OnSizeResourceChanged);
        WeakReferenceMessenger.Default.Register<TDesignPage, StrokeWidthResourceChangeMessage, string>(this,
            MessengerChannels.TDesign, OnStrokeWidthChanged);
        WeakReferenceMessenger.Default.Register<TDesignPage, TDesignModeResourceChangeMessage, string>(this,
            MessengerChannels.TDesign, OnModeChanged);
        WeakReferenceMessenger.Default.Register<TDesignPage, TDesignVariantResourceChangeMessage, string>(this,
            MessengerChannels.TDesign, OnVariantChanged);
    }

    private void OnVariantChanged(TDesignPage recipient, TDesignVariantResourceChangeMessage message)
    {
        if (DataContext is TDesignPageViewModel vm)
        {
            vm.Viewer.Filter = message.Value == IconVariant.Filled ? IconInfo.IsFilled : IconInfo.IsOutline;
        }
    }

    private void OnModeChanged(TDesignPage recipient, TDesignModeResourceChangeMessage message)
    {
        Resources["TDesignMode"] = message.Value;
    }

    private void OnStrokeWidthChanged(TDesignPage recipient, StrokeWidthResourceChangeMessage message)
    {
        Resources["IconStrokeWidth"] = message.Value;
    }

    private void OnSizeResourceChanged(TDesignPage recipient, SizeResourceChangeMessage message)
    {
        Resources["IconSize"] = message.Value;
    }

    private void OnColorResourceChanged(TDesignPage recipient, ColorResourceChangeMessage message)
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
