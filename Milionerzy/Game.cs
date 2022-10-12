using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy
{
 
    internal class Game
    {
        private string questionFileName { get; set; } = "easy.txt"; // Name of file with questions; deafult - easy.txt
        private string resultsFileName { get; set; } = "results.txt"; // Name of file with questions; deafult - easy.txt

        public string playerName { get; set; }
        private int difficultyLevel { get; set; } = 0;
        public List<Question> questions { get; set; } // List of questions
        public int roundNumber { get; set; } =0; // Number of round         
       
        public bool isGameActive { get; set; } = false; // Indicates if game is active
        private bool fiftyFiftyBool { get; set; } = true; // First help bool
        private bool changeQuestionBool { get; set; } = true; // Second help bool
        private bool askAudienceBool { get; set; } = true; // Third help bool
        private string logo = @"
            .___  ___.  __   __       __    ______   .__   __.  _______ .______      ________  ____    ____ 
            |   \/   | |  | |  |     |  |  /  __  \  |  \ |  | |   ____||   _  \    |       /  \   \  /   / 
            |  \  /  | |  | |  |     |  | |  |  |  | |   \|  | |  |__   |  |_)  |   `---/  /    \   \/   /  
            |  |\/|  | |  | |  |     |  | |  |  |  | |  . `  | |   __|  |      /       /  /      \_    _/   
            |  |  |  | |  | |  `----.|  | |  `--'  | |  |\   | |  |____ |  |\  \----. /  /----.    |  |     
            |__|  |__| |__| |_______||__|  \______/  |__| \__| |_______|| _| `._____|/________|    |__|    " + "\n";

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
        public void show(string s)
        {
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
        }
        public Dictionary<int, string> Prizes { get { return prizes; } }
        public Game()
        {
            if (difficultyLevel == 0) questionFileName = "easy.txt";
            else if (difficultyLevel == 1) questionFileName = "medium.txt";
            else if (difficultyLevel == 2) questionFileName = "hard.txt";
        }
        public void Start()
        {         
            RunMainMenu();

        }
        public void RunMainMenu()
        {
            string[] options = { "Nowa gra", "Ustawienia", "Ostatnie wyniki", "Wyjście" };
            Menu mainMenu = new Menu(logo, options);
            int selectedIndex = mainMenu.Run(0);

            switch (selectedIndex)
            {
                case 0:
                    startGame();
                    break;
                case 1:
                    pickDifficultyLevel();
                    break;
                case 2:
                    Console.Clear();
                    showLastResults();
                    break;
                case 3:                   
                    exitGame();
                    break;
            }
        }
        
        private void pickDifficultyLevel()
        {
            string prompt = "Wybierz poziom trudności";
            string[] options = { "1. Łatwy", "2. Średni", "3. Trudny", "Wróć do menu" };

            Menu levelMenu = new Menu(prompt, options);
            int selectedIndex = levelMenu.Run(0);

            switch (selectedIndex)
            {
                case 0:
                    difficultyLevel = 0;
                    Console.WriteLine("Wybrałeś poziom łatwy."); Console.ReadKey(true);
                    RunMainMenu();
                    break;
                case 1:
                    difficultyLevel = 1;
                    Console.WriteLine("Wybrałeś poziom średni."); Console.ReadKey(true);
                    RunMainMenu();

                    break;
                case 2:
                    Console.WriteLine("Wybrałeś poziom trudny.");
                    difficultyLevel = 2; Console.ReadKey(true);
                    RunMainMenu();
                    break;
                case 3:
                    RunMainMenu();
                    break;
            }

        }

        private void exitGame()
        {
            show("Wciśnij dowolny przycisk aby wyjść...");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine(logo);
            show("Do następnego razu!");
            Environment.Exit(0);
        }
        private void showLastResults()
        {
            show("Ostatnie wyniki:\n");
            
            using (StreamReader sr = new StreamReader(resultsFileName))
            {                
                while(!sr.EndOfStream)
                     show(sr.ReadLine());
            }
            show("\n");
            show("Naciśnij dowolny przycisk aby przejść do głównego menu...");
            Console.ReadKey(true);
            RunMainMenu();
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
            //File.WriteAllText(filePath, newContent + currentContent);
            //using (StreamWriter sw = new StreamWriter(resultsFileName))
            //{
            //    currentContent = File.ReadAllText(resultsFileName);
            //    sw.WriteLine("{0} - {1}", playerName, winnings);
            //}
        }
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
            //Console.WriteLine("{0,-20} {1,20}", "Finished!", "[ok]");
        }
        public string winnerPrize (int qNumber,bool activeGame)
        {
            if (qNumber < 2 && activeGame)
            {
                show("Niestety nie udało Ci się wygrać :(");
                return "0zł";
            }
            else if (qNumber >= 2 && qNumber < 7 && activeGame)
            {
                show("Wygrałeś 1000zł!");
                return "1000zł";
            }
            else if (qNumber >= 7 && activeGame)
            {
                show("Wygrałeś 40 000zł!");
                return "40 000zł";
            }
            else if (!activeGame)
            {
                foreach (KeyValuePair<int, string> item in Prizes)
                {
                    if (item.Key == qNumber)
                    {
                        show($"Gratulacje wygrałeś {item.Value}");
                        return item.Value;
                    }
                }
            }
            return "0zł";
        }

        public void startGame()
        {
            Console.Clear();
            Console.WriteLine("Witaj w grze Milionerzy!\nPodaj swój nick: ");
            playerName = Console.ReadLine();
            Console.WriteLine("Drogi " + playerName + " GL HF");

            Console.ReadKey(true);

            questions = readQuestions();
            isGameActive = true;

  
            while (isGameActive && roundNumber < 13)
            {
                //Console.WriteLine(logo);
                //if (Console.ReadKey().Key == ConsoleKey.X)
                //    game.isGameActive = false;

                //game.changeQuestion(game.roundNumber); // Zamiana pytania
                //game.fiftyFifty(game.roundNumber); // Pół na pół
                showPrizes(roundNumber);

                string answer="";

                string prompt = questions[roundNumber].question;
                string[] options = {$"{questions[roundNumber].answerA}", $"{questions[roundNumber].answerB}"
                        ,$"{questions[roundNumber].answerC}",$"{questions[roundNumber].answerD}" };
                Menu answersMenu = new Menu(prompt, options);
                int selectedIndex = answersMenu.Run(1);

                switch (selectedIndex)
                {
                    case 0:
                        answer = "a";
                        break;
                    case 1:
                        answer = "b";
                        break;
                    case 2:
                        answer = "c";
                        break;
                    case 3:
                        answer = "d";
                        break;
                }

                //Console.WriteLine("Pytanie numer {0}", roundNumber);
                //Console.WriteLine(questions[roundNumber].question);
                //Console.Write(questions[roundNumber].answerA + "\t\t");
                //Console.WriteLine(questions[roundNumber].answerB);
                //Console.Write(questions[roundNumber].answerC + "\t\t");
                //Console.WriteLine(questions[roundNumber].answerD);

                //Console.WriteLine("Podaj odpowiedź:");
                //answer = Console.ReadLine();

                if (questions[roundNumber].isAnswerCorrect(answer))
                {
                    Console.WriteLine("Gratulacje dobra odpowiedź!");
                    Console.WriteLine("Twój stan konta to:{0}", Prizes[roundNumber]);
                }
                else
                {
                    Console.WriteLine("Niestety, odpowiedź {0} jest nieprawidłowa.\n Prawidłowa " +
                        "odpowiedź to {1}. Zakończyłeś grę na pytaniu numer {2}."
                        , answer, questions[roundNumber].correctAnswer, roundNumber);
                    var winnings=winnerPrize(roundNumber, isGameActive);
                    saveResult(winnings);
                    isGameActive = false;
                }
                if (roundNumber == 12)
                {
                    saveResult("1 000 000 zł");
                    Console.WriteLine("Gratulacje wygrałeś w grze Milionerzy!");
                    isGameActive = false;
                }
                roundNumber++;
            }
            isGameActive = false;

            show("Naciśnij dowolny przycisk aby przejść do głównego menu...");

            Console.ReadKey(true);
            RunMainMenu();
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
        
 
        public List<Question> readQuestions()
        {
            List<Question> questionList = new List<Question>();

            using (StreamReader sr = new StreamReader(questionFileName))
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
