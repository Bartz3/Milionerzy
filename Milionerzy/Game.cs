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
        public int roundNumber { get; set; }

        public bool isGameActive { get; set; } = false;

        public enum difficultyLevel
        {
            easy,
            medium,
            hard
        }
        public List<Question> readQuestions(string fileName)
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
