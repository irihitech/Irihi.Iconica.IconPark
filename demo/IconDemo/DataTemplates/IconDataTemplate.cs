using System;
using System.Linq;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Irihi.Iconica;
using Control = Avalonia.Controls.Control;

namespace IconDemo.DataTemplates;

public class IconDataTemplate: IDataTemplate
{
    public Control? Build(object? param)
    {
        if (param is not string s) return null;
        var type = typeof(IconicaBase).Assembly.GetTypes().FirstOrDefault(a => a.Name == s);
        if (type == null) return null;
        var icon = Activator.CreateInstance(type) as IconicaBase;
        return icon;
    }

    public bool Match(object? data)
    {
        return data is string;
    }
}