using Avalonia.Media;
using CommunityToolkit.Mvvm.Messaging.Messages;
using Irihi.Iconica;

namespace IconDemo.Messages;

public class ColorResourceChangeMessage(Color? value, string resourceKey) : ValueChangedMessage<Color?>(value)
{
    public string ResourceKey { get; } = resourceKey;
}

public class ModeResourceChangeMessage(IconMode value) : ValueChangedMessage<IconMode>(value)
{
    
}

public class SizeResourceChangeMessage(double value) : ValueChangedMessage<double>(value)
{
    
}

public class StrokeWidthResourceChangeMessage(double value) : ValueChangedMessage<double>(value)
{
    
}
