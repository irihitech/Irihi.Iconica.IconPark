# IRIHI ICONICA - TDesign

A flexible and customizable icon library for Avalonia applications, built on top of the [Tencent TDesign Icons](https://github.com/Tencent/tdesign-icons) collection.

## About

Irihi.Iconica.TDesign is a .NET library that provides 2,300+ icons for Avalonia applications. Icons are generated as native Avalonia controls from TDesign's SVG source, offering runtime customization capabilities.

## Key Features

- **2,300+ Icons**: Complete collection from Tencent TDesign Icons (Outline + Filled)
- **Multiple Icon Modes**: OutlineSingle, OutlineDouble, FilledDouble, and FilledMultiple
- **Runtime Customization**: Dynamically change colors (Stroke1 / Fill1 / Stroke2 / Fill2), stroke width, and line caps
- **Type-Safe**: Every icon is a strongly-typed C# class
- **Avalonia Native**: Icons are rendered as Avalonia controls using `DrawingContext`

## Usage

```xml
<Window.Styles>
    <Style Selector="tdicon|TDesignIconBase">
        <Setter Property="Stroke1" Value="#0052D9" />
        <Setter Property="Fill1" Value="#D9E1FF" />
    </Style>
</Window.Styles>

<StackPanel Orientation="Horizontal">
    <tdicon:AddCircle />
    <tdicon:AddCircleFilled />
    <tdicon:User Mode="FilledMultiple" />
</StackPanel>
```

## Regenerating Icons

The icon sources are checked out as a git submodule under `external/tdesign-icons`. After updating the submodule, regenerate the icon classes:

```bash
dotnet run --project src/IconGenerator.TDesign
```

This regenerates:

- `src/Irihi.Iconica.TDesign/Generated/Outline/*.cs` — icons with stroke layers (inherit `TDesignIconBase`)
- `src/Irihi.Iconica.TDesign/Generated/Filled/*.cs` — filled icons (inherit `TDesignIconFilledBase`)
- `demo/Irihi.Iconica.Demo/Models/IconInfo.TDesign.Generated.cs` — demo icon list

## License

The icon designs are copyrighted by the TDesign authors; the generated code is copyrighted by IRIHI Technology. See `LICENSE` and `NOTICE` for details.
