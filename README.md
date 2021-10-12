[![Mobile](https://github.com/brminnick/HelloMauiToolkit/actions/workflows/mobile.yml/badge.svg)](https://github.com/brminnick/HelloMauiToolkit/actions/workflows/mobile.yml)

# HelloMauiToolkit
The [.NET MAUI Community Toolkit](https://github.com/communitytoolkit/maui) is a collection of common elements for development with .NET MAUI that developers tend to replicate across multiple apps. It simplifies and demonstrates common developer tasks when building apps with .NET MAUI.

### .NET MAUI Community Toolkit: Converters

This specific example uses the [`ColorToHexRgbStringConverter`](https://github.com/CommunityToolkit/Maui/blob/202565a8ac06ae2df81123ebb87cce8c8ea673b9/src/CommunityToolkit.Maui/Converters/ColorToStringConverter.shared.cs#L25-L30).

#### Add XAML Namespace

At the top of your XAML file, add the following `xmlns`

```xml
xmlns:converters="clr-namespace:CommunityToolkit.Maui.Converters;assembly=CommunityToolkit.Maui"
```

#### Use `ColorToHexRgbStringConverter`

In your `Binding` assign `Converter={converters:ColorToHexRgbStringConverter}`:

```xml
Text="{Binding Path=ButtomBackgroundColor, Converter={converters:ColorToHexRgbStringConverter}}
```

<p align="center">
 <img src="https://user-images.githubusercontent.com/13558917/136874004-97d0792d-2561-44e9-afcb-9cc54ee35d02.png" width="500" />
</p>


