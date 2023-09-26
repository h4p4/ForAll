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
}