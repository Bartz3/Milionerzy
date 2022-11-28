using System.Windows.Input;

namespace MilionerzyWPF
{
    public class AnswerType
    {
        public override string ToString() =>
            Answer ?? "No data";

        public string? Answer { get; set; }
        public ICommand? CmdClick { get; set; }
    }
}
