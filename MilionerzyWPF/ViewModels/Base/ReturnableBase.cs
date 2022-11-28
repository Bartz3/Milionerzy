using System.Windows.Input;

namespace MilionerzyWPF
{
    public abstract class ReturnableBase : ViewModelBase
    {
        public ICommand? CmdReturn { get; set; } = new Command(() => { });
    }
}
