using System.Windows.Controls;

namespace MilionerzyWPF
{
    /// <summary>
    /// Interaction logic for GameControl.xaml
    /// </summary>
    public partial class GameControl : UserControl
    {
        public GameControl()
        {
            InitializeComponent();
            this.DataContext = new GameControlVM();
        }
    }
}
