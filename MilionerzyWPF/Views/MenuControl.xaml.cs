using System.Windows;
using System.Windows.Controls;

namespace MilionerzyWPF
{
    /// <summary>
    /// Interaction logic for MenuControl.xaml
    /// </summary>
    public partial class MenuControl : UserControl
    {
        public MenuControl()
        {
            InitializeComponent();
            this.DataContext = new MenuControlVM();
        }

        private void Exit_Click(object sender, RoutedEventArgs e) =>
            Application.Current.Shutdown();
    }
}
