using Avalonia.Controls.Templates;
using IconDemo.Models;
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