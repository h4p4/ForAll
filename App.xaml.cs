namespace test_forall
{
    using System.Threading;
    using System.Windows;
    using test_forall.Utils;
    using test_forall.Views;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Вызов метода инициализации стилей до инициализации окон.
            //StyleInitializer.Initialize();
            StyleInitializer.InitializeV2(false);

            // Инициализация окон.
            var mainWindow = new MainWindow();
            var someWindow = new SomeWindow();
            var someWindowWithControl = new SomeWindowWithControl();
            mainWindow.Show();
            someWindow.Show();
            someWindowWithControl.Show();
            StyleInitializer.InitializeV2(false);

        }
    }
}