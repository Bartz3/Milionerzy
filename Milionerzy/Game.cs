using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy
{
    internal class Game
    {
        public string playerName { get; set; }
        public List<Question> questions { get; set; }
        public int roundNumber { get; set; } =0;
       
        public bool isGameActive { get; set; } = false;
        private string fileName { get; set; } = "easy.txt";

        private Dictionary<int, string> prizes = new Dictionary<int, string>()
        {
            {0,"0 zł"},
            {1,"500 zł"},
            {2,"1000 zł"},
            {3,"2000 zł"},
            {4,"5000 zł"},
            {5,"10 000 zł"},
            {6,"20 000 zł"},
            {7,"40 000 zł"},
            {8,"75 000 zł"},
            {9,"125 000 zł"},
            {10,"250 000 zł"},
            {11,"500 000 zł"},
            {12,"1 000 000 zł"},
        };

        public enum DifficultyLevel
        {
            easy,
            medium,
            hard
        }
        public Game()
        {

        }
        public Game(int diffLvl)
        {
            if (diffLvl == 1) fileName = "easy.txt";
            else if (diffLvl == 2) fileName = "medium.txt";
            else if (diffLvl == 3) fileName = "hard.txt";
        }
        public List<Question> readQuestions()
        {
            List<Question> questionList = new List<Question>();

            using (StreamReader sr = new StreamReader(fileName))
            {
                int i = 0, questionNumber = -1;
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    switch (i)
                    {
                        case 0:
                            questionNumber++;
                            questionList.Add(new Question());
                            questionList[questionNumber].numberOfQuestion = questionNumber;
                            questionList[questionNumber].question = line;
                            break;
                        case 1:
                            questionList[questionNumber].answerA = line;
                            break;
                        case 2:
                            questionList[questionNumber].answerB = line;
                            break;
                        case 3:
                            questionList[questionNumber].answerC = line;
                            break;
                        case 4:
                            questionList[questionNumber].answerD = line;
                            break;
                        case 5:
                            questionList[questionNumber].correctAnswer = line;
                            break;
                        default:
                            break;
                    }
                    i++; i = i % 6;
                    //Console.WriteLine(line);
                }
            }
            return questionList;
        }
    }
}
