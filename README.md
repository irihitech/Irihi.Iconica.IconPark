# IRIHI ICONICA - IconPark

A flexible and customizable icon library for Avalonia applications, built on top of the [ByteDance IconPark](https://github.com/bytedance/iconpark) icon collection.

## About

Irihi.Iconica.IconPark is a .NET library that provides over 2,400 high-quality icons for Avalonia applications. Unlike traditional SVG icon libraries that require importing individual SVG files as static resources, this library generates native Avalonia controls from IconPark's SVG icons, offering superior flexibility and runtime customization capabilities.

## Key Features

- **2,400+ Icons**: Complete collection from ByteDance IconPark
- **Multiple Icon Modes**: Support for Line, Fill, TwoTone, and MultiColor modes
- **Runtime Customization**: Dynamically change colors, stroke width, and line caps
- **Type-Safe**: Every icon is a strongly-typed C# class
- **Avalonia Native**: Icons are rendered as Avalonia controls using `DrawingContext`
- **Performance Optimized**: Pre-parsed geometry data for efficient rendering

## Design Advantages

### Why Use This Library Instead of Direct SVG Resources?

#### 1. **Dynamic Color Customization**
Traditional approach:
```xml
<!-- Static SVG - Colors are fixed -->
<Image Source="/Assets/Icons/icon.svg" />
```

With Irihi.Iconica.IconPark:
```xml
<!-- Dynamic colors that can be changed at runtime -->
<iconPark:Bowling OuterStroke="Red" 
                  OuterFill="Blue" 
                  InnerStroke="White" 
                  InnerFill="LightBlue" />
```

#### 2. **Multiple Display Modes**
Switch between different icon styles at runtime:
- **Line Mode**: Outline only
- **Fill Mode**: Solid fill
- **TwoTone Mode**: Two-color design
- **MultiColor Mode**: Full color palette

```xml
<iconPark:Bowling Mode="Line" />
<iconPark:Bowling Mode="Fill" />
<iconPark:Bowling Mode="TwoTone" />
<iconPark:Bowling Mode="MultiColor" />
```

#### 3. **Consistent Sizing and Scaling**
Icons automatically scale to any size without quality loss:
```xml
<iconPark:Bowling Width="16" Height="16" />
<iconPark:Bowling Width="64" Height="64" />
<iconPark:Bowling Width="256" Height="256" />
```

#### 4. **Stroke Customization**
Adjust stroke width, line caps, and joins dynamically:
```xml
<iconPark:Bowling StrokeWidth="2" 
                  LineCap="Round" 
                  LineJoin="Round" />
```

#### 5. **Type Safety and IntelliSense**
All icons are strongly-typed classes with full IntelliSense support in your IDE.

#### 6. **No Asset Management Overhead**
No need to manage individual SVG files, worry about naming conflicts, or maintain asset folders. All icons are compiled into the library.

## Building from Source

### Prerequisites
- .NET 8.0 SDK or later
- Git

### Build Steps

#### 1. Clone the Repository
```bash
git clone https://github.com/irihitech/Irihi.Iconica.IconPark.git
cd Irihi.Iconica.IconPark
```

#### 2. Initialize the IconPark Submodule
The IconPark repository is included as a Git submodule and must be initialized:
```bash
git submodule init
git submodule update
```

This will clone the ByteDance IconPark repository into the `iconpark` directory.

#### 3. Run the Icon Generator
The IconGenerator tool parses SVG files from IconPark and generates C# icon classes:
```bash
cd src/IconGenerator
dotnet run
```

This process:
- Reads SVG icon definitions from `iconpark/packages/react/src/icons/`
- Parses SVG paths, shapes, and attributes
- Generates C# classes in `src/Irihi.Iconica.IconPark/Generated/`
- Creates metadata for the demo application

#### 4. Build the Solution
```bash
cd ../..
dotnet build Irihi.Iconica.IconPark.sln
```

The build will produce:
- `Irihi.Iconica.IconPark.dll` - The main icon library
- `IconDemo` - A sample application showcasing all icons

### Running the Demo
```bash
cd demo/IconDemo
dotnet run
```

The demo application provides a searchable gallery of all available icons with live customization options.

## Usage Example

```xml
<Window xmlns="https://github.com/avaloniaui"
        xmlns:iconPark="clr-namespace:Irihi.Iconica.IconPark.Icons;assembly=Irihi.Iconica.IconPark">
    <StackPanel>
        <!-- Basic icon -->
        <iconPark:Bowling Width="24" Height="24" />
        
        <!-- Customized icon -->
        <iconPark:Bowling Width="48" Height="48"
                          Mode="TwoTone"
                          OuterStroke="#333333"
                          OuterFill="#2F88FF"
                          InnerStroke="White"
                          InnerFill="#43CCF8"
                          StrokeWidth="4"
                          LineCap="Round" />
    </StackPanel>
</Window>
```

## License

- Original IconPark designs: Copyright © 2025 ByteDance IconPark Authors
- Generated code and library: Copyright © 2025 IRIHI Technology Co., Ltd.

## Credits

This library is built on top of the excellent [IconPark](https://github.com/bytedance/iconpark) project by ByteDance.
