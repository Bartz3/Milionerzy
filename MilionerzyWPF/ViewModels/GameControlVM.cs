using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MilionerzyWPF
{
    public class GameControlVM : ReturnableBase
    {
        public GameControlVM()
        {
            easy = GetQuestions("Assets/easy.txt");
            medium = GetQuestions("Assets/medium.txt");
            hard = GetQuestions("Assets/hard.txt");
            
            questions = easy;
            CurrentQuestion = Questions.First();
        }

        public void Clicked(int position)
        {
            if (CurrentQuestion.CorrectAnswer != position)
            {

                CmdReturn?.Execute(null);
                return;
            }

            Questions.RemoveAt(0);
            CurrentQuestion = Questions.First();
            if (CurrentQuestion.Question == Questions.Last().Question)
                CmdReturn?.Execute(null);

        }

        public string[] Rewards { get; set; } =
        {
            "1 000 000",
            "500 000",
            "250 000",
            "125 000",
            "75 000",
            "40 000",
            "20 000",
            "10 000",
            "5 000",
            "2 000",
            "1 000",
            "5 000",
            "0",
        };

        public QuestionItem? CurrentQuestion { get=> currentQuestion; set => Set(value, ref currentQuestion); }
        public List<QuestionItem> Questions { get => questions; set => Set(value, ref questions); }

        private QuestionItem currentQuestion;
        private List<QuestionItem> questions;
        
        private readonly List<QuestionItem>? easy  ;
        private readonly List<QuestionItem>? medium;
        private readonly List<QuestionItem>? hard  ;

        private List<QuestionItem> GetQuestions(string filename) =>
            File.ReadLines("Assets/easy.txt")
                .Chunk(6)
                .Where(i => i.Length == 6)
                .Select(i => new QuestionItem(i, this))
                .ToList();
    }
}
