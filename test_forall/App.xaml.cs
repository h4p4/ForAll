namespace test_forall
{
    using System.Windows;

    using UI.Styles.Utils;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            // Вызов метода инициализации стилей до инициализации окон.
            StyleInitializer.ApplyTheme(typeof(MainWindow).Assembly, Theme.Dark);
        }
    }
}