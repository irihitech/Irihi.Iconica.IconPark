using System;
using System.Linq;
using Avalonia.Controls.Templates;
using IconPark.Icons;
using Control = Avalonia.Controls.Control;

namespace IconDemo.DataTemplates;

public class IconDataTemplate: IDataTemplate
{
    public Control? Build(object? param)
    {
        if (param is not string s) return null;
        var type = typeof(IconParkIconBase).Assembly.GetTypes().FirstOrDefault(a => a.Name == s);
        if (type == null) return null;
        var icon = Activator.CreateInstance(type) as Control;
        return icon;
    }

    public bool Match(object? data)
    {
        return data is string;
    }
}