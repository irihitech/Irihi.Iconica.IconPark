namespace Irihi.Iconica.TDesign;

public abstract class TDesignIconFilledBase : TDesignIconBase
{
    static TDesignIconFilledBase()
    {
        ModeProperty.OverrideDefaultValue<TDesignIconFilledBase>(IconMode.FilledDouble);
    }
}