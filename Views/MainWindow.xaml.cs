namespace test_forall.Views
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Инициализация окон.
            var someWindow = new SomeWindow();
            var someWindowWithControl = new SomeWindowWithControl();
            someWindow.Show();
            someWindowWithControl.Show();
        }
    }
}
