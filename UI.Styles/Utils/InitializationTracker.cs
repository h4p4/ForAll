namespace UI.Styles.Utils
{
    using System;
    using System.Windows;
    using System.Windows.Controls;

    public static class InitializationTracker
    {
        public static event EventHandler<ContentControl> ContentControlLoaded;

        public static void StartTracking()
        {
            EventManager.RegisterClassHandler(typeof(ContentControl), FrameworkElement.LoadedEvent,
                new RoutedEventHandler(OnContentControlLoaded));
        }

        private static void OnContentControlLoaded(object sender, RoutedEventArgs e)
        {
            var contentControl = (ContentControl)sender;
            ContentControlLoaded?.Invoke(sender, contentControl);
        }
    }
}