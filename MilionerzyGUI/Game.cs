using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using MilionerzyGUI.Properties;

namespace Milionerzy
{
 
    internal class Game
    {
        private string questionFileName { get; set; } = "easy.txt"; // Name of file with questions; deafult - easy.txt
        private string resultsFileName { get; set; } = "results.txt"; // Name of file with questions; deafult - easy.txt

        public string playerName { get; set; }
        public List<Question> questions { get; set; } // List of questions
        public int roundNumber { get; set; } =0; // Number of round         
       
        public bool isGameActive { get; set; } = false; // Indicates if game is active
        private bool fiftyFiftyBool { get; set; } = true; // First help bool
        private bool changeQuestionBool { get; set; } = true; // Second help bool
        private bool askAudienceBool { get; set; } = true; // Third help bool

        public int fiftyFiftyBoolRound { get; set; } = -1; // In which round 50/50 was used

        private string deletedAnswers { get; set; } = "";
        public int level { get; set; } = 0;


        private Dictionary<int, string> prizes = new Dictionary<int, string>()
        {
            {0, "0 zł"},
            {1, "500 zł"},
            {2, "1000 zł"},
            {3, "2000 zł"},
            {4, "5000 zł"},
            {5, "10 000 zł"},
            {6, "20 000 zł"},
            {7, "40 000 zł"},
            {8, "75 000 zł"},
            {9, "125 000 zł"},
            {10,"250 000 zł"},
            {11,"500 000 zł"},
            {12,"1 000 000 zł"},
        };
        public void show(string s)
        {
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
        }
        public Dictionary<int, string> Prizes { get { return prizes; } }
        public void difficultyLevelVoid(int lv)
        {
            switch (lv)
            {
                case 0: questionFileName = "easy.txt";
                    break;
                case 1:
                    questionFileName = "medium.txt";
                    break;
                case 2:
                    questionFileName = "hard.txt";
                    break;

            }
        }
        public void Start()
        {
            SoundPlayer intro = new SoundPlayer("intro.wav");
            intro.Load();
            intro.Play();
        }
        public void winnerEnding()
        {
            SoundPlayer outro = new SoundPlayer("outro.wav");
            outro.Load();
            outro.Play();

        }
    private string questionMethod() { return "Xd"; }
        public void startGame()
        {
            //preGameDisplay();
            string answer;
            while (isGameActive && roundNumber < 13)
            {

                answer = questionMethod();
                while (answer == null) answer = questionMethod();
                
                if (questions[roundNumber].isAnswerCorrect(answer))
                {
                    //Console.WriteLine("\n");
                    if (roundNumber == 2 || roundNumber == 7)
                    {
                        //show("Gratulacje dobra odpowiedź! Uzyskałeś próg gwarantowany!");
                        //show($"Twój stan konta to:{Prizes[roundNumber]}");
                    }
                    else
                    {
                        //show("Gratulacje dobra odpowiedź!");
                        //show($"Twój stan konta to:{Prizes[roundNumber]}");
                    }

                    //showPrizes(roundNumber);
                    //Console.ReadKey();
                }
                else
                {
                    //Console.WriteLine("\n");
                    //show($"Niestety, odpowiedź {answer} jest nieprawidłowa." +
                    //    $" Prawidłowa odpowiedź to {questions[roundNumber].correctAnswer}. Zakończyłeś grę na pytaniu numer {roundNumber}.");
                    SoundPlayer badAnswer = new SoundPlayer("badAnswer.wav");
                    badAnswer.Load();
                    badAnswer.Play();


                    //var winnings = winnerPrize(roundNumber, isGameActive);
                    //saveResult(winnings);
                    isGameActive = false;

                }
                if (roundNumber == 12)
                {
                    SoundPlayer outro = new SoundPlayer("outro.wav");
                    outro.Load();
                    outro.Play();
                    isGameActive = false;
                }
                roundNumber++;
                //gameLogic(answer);

            }
            isGameActive = false;
            resetGame();

            //show("Naciśnij dowolny przycisk aby przejść do głównego menu...");

            Console.ReadKey(true);
            //RunMainMenu();
        }
        private void exitGame()
        {
        }
        public void resetGame()
        {
            askAudienceBool = true;
            changeQuestionBool = true;
            fiftyFiftyBool = true;
            deletedAnswers = "";
            fiftyFiftyBoolRound = -1;
        }

        public List<string> lastResults()
        {
            //StringBuilder sb = new StringBuilder();
            List<string> output = new List<string>();
            using (StreamReader sr = new StreamReader(resultsFileName))
            {                
                while(!sr.EndOfStream)
                {
                     //sb.Append(sr.ReadLine());
                    output.Add(sr.ReadLine());
                }    
            }
            //return sb.ToString();
            return output;
        }
        private void saveResult(string winnings)
        {
            string currentContent = String.Empty;
            if (File.Exists(resultsFileName))
            {
                currentContent = File.ReadAllText(resultsFileName);
            }
            var eee = $"{playerName} - {winnings}";
            File.WriteAllText(resultsFileName, eee +"\n"+ currentContent);
       
        }
        public string winnerPrize (int qNumber,bool activeGame)
        {

            if (qNumber < 2 && activeGame)
            {
                saveResult("0zł");
                return "0zł";

            }
            else if (qNumber >= 2 && qNumber < 7 && activeGame)
            {
                saveResult("1000zł");
                return "1000zł";

            }
            else if (qNumber >= 7 && activeGame)
            {
                saveResult("40 000zł");
                return "40 000zł";

            }
            else if (!activeGame)
            {
                foreach (KeyValuePair<int, string> item in Prizes)
                {
                    if (item.Key == qNumber)
                    {
                        saveResult(item.Value.ToString());
                        return item.Value.ToString();
        
                    }
                }
            }
            return null;
   
        }    
     
        public void askAudience(int qNumber)
        {
            Random rand = new Random();
            int goodAnswerPercent = 0, percent1 = 0, percent2 = 0, percent3 = 0,cem=100;

            bool isUsed = false;
            if (askAudienceBool)
            {
                string correctAnswer = questions[qNumber].correctAnswer;

                if(fiftyFiftyBoolRound!=roundNumber)
                {
                    if (qNumber < 9) goodAnswerPercent = rand.Next(40, 70);
                    else goodAnswerPercent = rand.Next(20, 50);

                    cem -= goodAnswerPercent;

                    percent1 = rand.Next(0, cem);
                    cem -= percent1;

                    percent2 = rand.Next(0, cem);
                    cem -= percent2;

                    percent3 = cem;

                    if (questions[qNumber].answerA.Substring(0, 1) == correctAnswer)
                    {
                        questions[qNumber].answerA += " " + goodAnswerPercent.ToString() + "%";
                        questions[qNumber].answerB += " " + percent1.ToString() + "%";
                        questions[qNumber].answerC += " " + percent2.ToString() + "%";
                        questions[qNumber].answerD += " " + percent3.ToString() + "%";
                    }                              
                    if (questions[qNumber].answerB.Substring(0, 1) == correctAnswer)  
                    {                              
                        questions[qNumber].answerB += " " + goodAnswerPercent.ToString() + "%";
                        questions[qNumber].answerA += " " + percent1.ToString() + "%";
                        questions[qNumber].answerC += " " + percent2.ToString() + "%";
                        questions[qNumber].answerD += " " + percent3.ToString() + "%";
                    }                              
                    if (questions[qNumber].answerC.Substring(0, 1) == correctAnswer)  
                    {                              
                        questions[qNumber].answerC += " " + goodAnswerPercent.ToString() + "%";
                        questions[qNumber].answerA += " " + percent1.ToString() + "%";
                        questions[qNumber].answerB += " " + percent2.ToString() + "%";
                        questions[qNumber].answerD += " " + percent3.ToString() + "%";
                    }                              
                    if (questions[qNumber].answerD.Substring(0, 1) == correctAnswer)  
                    {                              
                        questions[qNumber].answerD += " " + goodAnswerPercent.ToString() + "%";
                        questions[qNumber].answerA += " " + percent1.ToString() + "%";
                        questions[qNumber].answerB += " " + percent2.ToString() + "%";
                        questions[qNumber].answerC += " " + percent2.ToString() + "%";

                    }
                }
                else //xd
                {
                    string[] twoAnswersDeleted = deletedAnswers.Split(' ');

                    if (qNumber < 9) goodAnswerPercent = rand.Next(48, 70);
                    else goodAnswerPercent = rand.Next(35, 50);

                    cem -= goodAnswerPercent;

                        if ("a" == twoAnswersDeleted[0] || "a" == twoAnswersDeleted[1])  // A to zła odpowiedź(wyeliminowana w 50/50)
                        {
                            ;
                        }
                        else if("a" == correctAnswer) // A to dobra odpowiedź
                        {
                            questions[qNumber].answerA += " " + goodAnswerPercent.ToString() + "%";
                        }
                        else // A to zła odpowiedź została z dobrą
                        {
                            questions[qNumber].answerA += " " + cem.ToString() + "%";
                        }

                        if ("b" == twoAnswersDeleted[0] || "b" == twoAnswersDeleted[1])  
                        {
                            ;
                        }
                        else if ("b" == correctAnswer) 
                        {
                            questions[qNumber].answerB += " " + goodAnswerPercent.ToString() + "%";
                        }
                        else 
                        {
                            questions[qNumber].answerB += " " + cem.ToString() + "%";
                        }

                        if ("c" == twoAnswersDeleted[0] || "c" == twoAnswersDeleted[1])
                        {
                            ;
                        }
                        else if ("c" == correctAnswer)
                        {
                            questions[qNumber].answerC += " " + goodAnswerPercent.ToString() + "%";
                        }
                        else
                        {
                            questions[qNumber].answerC += " " + cem.ToString() + "%";
                        }

                        if ("d" == twoAnswersDeleted[0] || "d" == twoAnswersDeleted[1])
                        {
                            ;
                        }
                        else if ("d" == correctAnswer)
                        {
                            questions[qNumber].answerD += " " + goodAnswerPercent.ToString() + "%";
                        }
                        else
                        {
                            questions[qNumber].answerD += " " + cem.ToString() + "%";
                        }
                    
                }

                askAudienceBool = false;
            }
        }
        public void fiftyFifty(int qNumber) // Pierwsze koło ratunkowe 50/50
        {
            if (fiftyFiftyBool)
            {
                string correctA = questions[qNumber].correctAnswer;
                int deletedAnswersCounter = 0;

                if (questions[qNumber].answerA.Substring(0, 1) != correctA && deletedAnswersCounter < 2)
                {
                    questions[qNumber].answerA = "";
                    deletedAnswers += "a ";
                    deletedAnswersCounter++;
                }
                if (questions[qNumber].answerB.Substring(0, 1) != correctA && deletedAnswersCounter < 2)
                {
                    questions[qNumber].answerB = "";
                    deletedAnswers += "b ";
                    deletedAnswersCounter++;
                }
                if (questions[qNumber].answerC.Substring(0, 1) != correctA && deletedAnswersCounter < 2)
                {
                    questions[qNumber].answerC = "";
                    deletedAnswers += "c ";
                    deletedAnswersCounter++;
                }
                if (questions[qNumber].answerD.Substring(0, 1) != correctA && deletedAnswersCounter < 2)
                {
                    questions[qNumber].answerD = "";
                    deletedAnswers += "d ";
                    deletedAnswersCounter++;
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
 
        public List<Question> readQuestions()
        {
            List<Question> questionList = new List<Question>();

            using (StreamReader sr = new StreamReader(questionFileName,Encoding.UTF8))
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
                }
            }
            return questionList;
        }

        public int[] askAudience2(int qNumber)
        {
            Random rand = new Random();
            int goodAnswerPercent = 0, percent1 = 0, percent2 = 0, percent3 = 0, cem = 100;

            int[] output = new int[4];
            output[0] = percent1; output[1] = percent2; output[2] = percent3; output[3] = goodAnswerPercent;
            bool isUsed = false;
            if (askAudienceBool)
            {
                string correctAnswer = questions[qNumber].correctAnswer;

                if (fiftyFiftyBoolRound != roundNumber)
                {
                    if (qNumber < 9) goodAnswerPercent = rand.Next(40, 70);
                    else goodAnswerPercent = rand.Next(20, 50);

                    cem -= goodAnswerPercent;

                    percent1 = rand.Next(0, cem);
                    cem -= percent1;

                    percent2 = rand.Next(0, cem);
                    cem -= percent2;

                    percent3 = cem;

                    if (questions[qNumber].answerA.Substring(0, 1) == correctAnswer)
                    {

                        output[0] = goodAnswerPercent; output[1] = percent1; output[2]= percent2; output[3] = percent3;
                    }
                    if (questions[qNumber].answerB.Substring(0, 1) == correctAnswer)
                    {

                        output[0] = percent1; output[1] = goodAnswerPercent; output[2] = percent2; output[3] = percent3;
                    }
                    if (questions[qNumber].answerC.Substring(0, 1) == correctAnswer)
                    {

                        output[0] = goodAnswerPercent; output[1] = percent1; output[2] = percent2; output[3] = percent3;
                    }
                    if (questions[qNumber].answerD.Substring(0, 1) == correctAnswer)
                   {
     
                        output[0] = percent1; output[1] = percent2; output[2] = percent3; output[3] = goodAnswerPercent;

                    }
                }
                else //xd
                {
                    string[] twoAnswersDeleted = deletedAnswers.Split(' ');

                    if (qNumber < 9) goodAnswerPercent = rand.Next(48, 70);
                    else goodAnswerPercent = rand.Next(35, 50);

                    cem -= goodAnswerPercent;

                    if ("a" == twoAnswersDeleted[0] || "a" == twoAnswersDeleted[1])  // A to zła odpowiedź(wyeliminowana w 50/50)
                    {
                        ;
                    }
                    else if ("a" == correctAnswer) // A to dobra odpowiedź
                    {
                        //questions[qNumber].answerA += " " + goodAnswerPercent.ToString() + "%";
                        output[0] = goodAnswerPercent;
                    }
                    else // A to zła odpowiedź została z dobrą
                    {
                        //questions[qNumber].answerA += " " + cem.ToString() + "%";
                        output[0] = goodAnswerPercent = cem;
                    }

                    if ("b" == twoAnswersDeleted[0] || "b" == twoAnswersDeleted[1])
                    {
                        ;
                    }
                    else if ("b" == correctAnswer)
                    {
                        //questions[qNumber].answerB += " " + goodAnswerPercent.ToString() + "%";
                        output[1] = goodAnswerPercent;
                    }
                    else
                    {
                        //questions[qNumber].answerB += " " + cem.ToString() + "%";
                        output[1] = cem;
                    }

                    if ("c" == twoAnswersDeleted[0] || "c" == twoAnswersDeleted[1])
                    {
                        ;
                    }
                    else if ("c" == correctAnswer)
                    {
                        //questions[qNumber].answerC += " " + goodAnswerPercent.ToString() + "%";
                        output[2] = goodAnswerPercent;
                    }
                    else
                    {
                        //questions[qNumber].answerC += " " + cem.ToString() + "%";
                        output[2] = cem;
                    }

                    if ("d" == twoAnswersDeleted[0] || "d" == twoAnswersDeleted[1])
                    {
                        ;
                    }
                    else if ("d" == correctAnswer)
                    {
                        //questions[qNumber].answerD += " " + goodAnswerPercent.ToString() + "%";
                        output[3] = goodAnswerPercent;
                    }
                    else
                    {
                        //questions[qNumber].answerD += " " + cem.ToString() + "%";
                        output[3] = cem;
                    }

                }

                askAudienceBool = false;
                
            }
            return output;
        }


    }
}
