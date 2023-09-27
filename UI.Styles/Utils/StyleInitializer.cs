namespace UI.Styles.Utils;

using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

public static class StyleInitializer
{
    /// <summary>
    /// Текущая тема.
    /// </summary>
    public static Theme CurrentTheme { get; set; } = Theme.NotSet;

    /// <summary>
    /// Инициализация стилей для всех наследников <see cref="ContentControl" /> из словаря ресурсов.
    /// </summary>
    /// <param name="assembly"> Сборка для элементов которой будет применена тема. </param>
    /// <param name="theme"> Тема. </param>
    /// <remarks>
    /// Вызывать 1 раз перед инициализацией элементов для которых нужно применить стиль.
    /// </remarks>
    public static void ApplyTheme(Assembly assembly, Theme theme)
    {
        // Выходим если тема уже установлена/передали пустую тему.
        if (theme == Theme.NotSet || CurrentTheme != Theme.NotSet)
            return;

        CurrentTheme = theme;

        InitializationTracker.StartTracking();
        InitializationTracker.ContentControlLoaded += OnControlLoaded;
    }

    private static void OnControlLoaded(object? sender, ContentControl e)
    {
        var themeString = CurrentTheme == Theme.Dark ? "Dark" : "Light";
        var resources = new ResourceDictionary
        {
            Source = new Uri($"pack://application:,,,/UI.Styles;component/Styles/{themeString}Theme.xaml",
                UriKind.Absolute)
        };

        e.Resources.MergedDictionaries.Add(resources);
    }
}