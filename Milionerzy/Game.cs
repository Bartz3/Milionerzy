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
        public List<Question> questions { get; set; } // List of questions
        public int roundNumber { get; set; } =0; // Number of round 
       
        public bool isGameActive { get; set; } = false; // Indicates if game is active
        private string fileName { get; set; } = "easy.txt"; // Name of file with questions; deafult - easy.txt
        private bool fiftyFiftyBool { get; set; } = true; // First help bool
        private bool changeQuestionBool { get; set; } = true; // Second help bool
        private bool askAudienceBool { get; set; } = true; // Third help bool

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
        public void showPrizes(int qNumber)
        {
            foreach (KeyValuePair<int, string> item in Prizes.Reverse())
            {
                if (item.Key == qNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0}. {1}", item.Key, item.Value);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if(item.Key==2 || item.Key == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{0}. {1}", item.Key, item.Value);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else Console.WriteLine("{0}. {1}", item.Key, item.Value);
            }
            Console.WriteLine("{0,-20} {1,20}", "Finished!", "[ok]");
        }
        public Dictionary<int,string> Prizes { get { return prizes; } }

        public enum DifficultyLevel
        {
            easy,
            medium,
            hard
        }
        public Game()
        {

        }
        public void askAudience(int qNumber)
        {
            if (askAudienceBool)
            {

                askAudienceBool = false;
            }
        }
        public void fiftyFifty(int qNumber) // Pierwsze koło ratunkowe 50/50
        {
            if (fiftyFiftyBool)
            {
                string correctA = questions[qNumber].correctAnswer;
                int deletedAnswers = 0;

                if (questions[qNumber].answerA.Substring(0, 1) != correctA && deletedAnswers < 2)
                {
                    questions[qNumber].answerA += "XXX";
                    deletedAnswers++;
                }
                if (questions[qNumber].answerB.Substring(0, 1) != correctA && deletedAnswers < 2)
                {
                    questions[qNumber].answerB += "XXX";
                    deletedAnswers++;
                }
                if (questions[qNumber].answerC.Substring(0, 1) != correctA && deletedAnswers < 2)
                {
                    questions[qNumber].answerC += "XXX";
                    deletedAnswers++;
                }
                if (questions[qNumber].answerD.Substring(0, 1) != correctA && deletedAnswers < 2)
                {
                    questions[qNumber].answerD += "XXX";
                    deletedAnswers++;
                }
                fiftyFiftyBool = false;
            }

        }
        public void changeQuestion(int qNumber)
        {
            if (changeQuestionBool)
            {
                var temp = qNumber.ToString() + ". " + questions[13].question.Substring(questions[13].question.IndexOf('.') + 1);
                questions[qNumber].question = temp;
                questions[qNumber].answerA = questions[13].answerA;
                questions[qNumber].answerB = questions[13].answerB;
                questions[qNumber].answerC = questions[13].answerC;
                questions[qNumber].answerD = questions[13].answerD;
                questions[qNumber].correctAnswer = questions[13].correctAnswer;

                changeQuestionBool = false;
            }

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
