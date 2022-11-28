using System.Windows.Controls;

namespace MilionerzyWPF
{
    /// <summary>
    /// Interaction logic for ScoresControl.xaml
    /// </summary>
    public partial class ScoresControl : UserControl
    {
        public ScoresControl()
        {
            InitializeComponent();
            this.DataContext = new ScoresControlVM();
        }
    }
}
