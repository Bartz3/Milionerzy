using System.Windows.Input;

namespace MilionerzyWPF
{
    public class MenuControlVM : ViewModelBase
    {
        public ICommand CmdNewGame  { get; set; } = new Command(() => { });
        public ICommand CmdSettings { get; set; } = new Command(() => { });
        public ICommand CmdScores   { get; set; } = new Command(() => { });
    }
}
