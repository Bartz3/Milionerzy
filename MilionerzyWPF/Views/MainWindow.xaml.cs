using System.Windows;

namespace MilionerzyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowVM();
        }

        private void Exit_Click(object sender, RoutedEventArgs e) => 
            Application.Current.Shutdown();
    }
}
