using System;
using System.Linq;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using IconDemo.Models;
using Irihi.Iconica;
using Control = Avalonia.Controls.Control;

namespace IconDemo.DataTemplates;

public class IconDataTemplate: IDataTemplate
{
    public static IconDataTemplate Instance { get; } = new();
    public Control? Build(object? param)
    {
        if (param is IconInfo i)
        {
            return i.Creator?.Invoke();
        }
        return null;
    }

    public bool Match(object? data)
    {
        return data is IconInfo;
    }
}