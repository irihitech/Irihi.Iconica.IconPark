using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using IconDemo.Models;

namespace IconDemo.ViewModels;

public partial class IconDetailViewModel : ObservableObject
{
    private readonly IReadOnlyList<IconInfo> _source;

    [ObservableProperty] public partial IconInfo? IconInfo { get; set; }

    public IconDetailViewModel(IReadOnlyList<IconInfo> source)
    {
        _source = source;
        WeakReferenceMessenger.Default.Register<IconDetailViewModel, IconInfo>(this, OnIconChanged);
        IconInfo = source.FirstOrDefault();
    }

    private void OnIconChanged(IconDetailViewModel recipient, IconInfo message)
    {
        // 只接受来自本页面数据源的图标，避免另一个页面的选中消息串扰。
        if (_source.Contains(message))
        {
            IconInfo = message;
        }
    }
}