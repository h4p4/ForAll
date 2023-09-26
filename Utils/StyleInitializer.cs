namespace test_forall.Utils;

using System;
using System.Windows;
using System.Windows.Controls;

public static class StyleInitializer
{
    /// <summary>
    /// Инициализация стилей для всех наследников <see cref="ContentControl"/> из словаря ресурсов.
    /// </summary>
    /// <remarks> Вызывать 1 раз перед инициализацией любого наследника <see cref="ContentControl"/>, либо перед инициализацией всех </remarks>
    public static void Initialize()
    {
        var resources = new ResourceDictionary
        {
            Source = new Uri("pack://application:,,,/test_forall;component/Styles/LightTheme.xaml", UriKind.Absolute)
        };

        var style = new Style(typeof(ContentControl));
        style.Resources.MergedDictionaries.Add(resources);

        FrameworkElement.StyleProperty.OverrideMetadata(typeof(ContentControl), new FrameworkPropertyMetadata(style));
    }

    public static ResourceDictionary InitializeV2(bool isLight)
    {
        var color = isLight ? "LightColors" : "DarkColors";

        var mainResources = new ResourceDictionary
        {
            Source = new Uri("pack://application:,,,/test_forall;component/Styles/Style.xaml", UriKind.Absolute)
        };

        var colorResources = new ResourceDictionary
        {
            Source = new Uri($"pack://application:,,,/test_forall;component/Styles/{color}.xaml", UriKind.Absolute)
        };
        mainResources.MergedDictionaries.Clear();
        mainResources.MergedDictionaries.Add(colorResources);
        return mainResources;
    }
}