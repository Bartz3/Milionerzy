using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MilionerzyWPF
{
    [DebuggerDisplay("{Question}")]
    public class QuestionItem
    {
        public QuestionItem(IEnumerable<string> lines, GameControlVM vm)
        {
            string[] array = lines.Take(6).ToArray();
            Question = array[0];
            Answers = array[1..5]
                .Select((answer, index) => new AnswerType()
                {
                    Answer = answer,
                    CmdClick = new Command(() => vm.Clicked(index))
                })
                .ToArray();
            CorrectAnswer = array[5][0] - 'a';
        }

        public string Question { get; set; }
        public AnswerType[] Answers { get; set; }
        public int CorrectAnswer { get; set; }
    }
}
